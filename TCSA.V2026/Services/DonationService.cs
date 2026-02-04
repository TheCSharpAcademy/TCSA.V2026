using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;       // UserStripe (you said you already have it)
using TCSA.V2026.Data;
using TCSA.V2026.Data.Enums;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Options;
using TCSA.V2026.Data.Models.Requests;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface IDonateService
{
    Task<ServiceResponse<CreateDonationCheckoutResponse>> CreateCheckoutAsync(CreateDonationCheckoutRequest request);
    Task<ServiceResponse<List<UserDonation>>> GetUserDonationsAsync(string userId, int take = 20);
}

public sealed class DonateService : IDonateService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly IStripeClient _stripeClient;
    private readonly StripeOptions _stripeOptions;
    private readonly ILogger<DonateService> _logger;

    public DonateService(
        IDbContextFactory<ApplicationDbContext> factory,
        IStripeClient stripeClient,
        IOptions<StripeOptions> stripeOptions,
        ILogger<DonateService> logger)
    {
        _factory = factory;
        _stripeClient = stripeClient;
        _stripeOptions = stripeOptions.Value;
        _logger = logger;
    }

    public async Task<ServiceResponse<CreateDonationCheckoutResponse>> CreateCheckoutAsync(CreateDonationCheckoutRequest request)
    {
        var response = ValidateDonationRequest(request);
        if (!response.IsSuccessful) return response;

        var currency = NormalizeCurrency(request.Currency);
        var amountCents = checked(request.AmountDollars * 100);

        await using var db = await _factory.CreateDbContextAsync();

        // 1) Ensure we have a Stripe customer stored for this user
        var userStripe = await GetOrCreateUserStripeAsync(db, request.AppUserId);
        await EnsureStripeCustomerAsync(db, userStripe, request.Email);

        // 2) Create donation row first (gives us an internal ID for metadata)
        var donation = new UserDonation
        {
            AppUserId = request.AppUserId,
            AmountCents = amountCents,
            Currency = currency,
            Status = DonationStatus.Created,
            CreatedUtc = DateTime.UtcNow,
        };

        db.UserDonations.Add(donation);
        await db.SaveChangesAsync(); // donation.Id created

        // 3) Create Checkout Session in payment mode
        var session = await CreateDonationCheckoutSessionAsync(userStripe.StripeCustomerId, donation, currency);

        // 4) Save Stripe session id for reconciliation/debugging
        donation.StripeCheckoutSessionId = session.Id;
        await db.SaveChangesAsync();

        return new ServiceResponse<CreateDonationCheckoutResponse>
        {
            IsSuccessful = true,
            Message = "Redirect the user to Stripe Checkout to complete the donation.",
            Data = new CreateDonationCheckoutResponse
            {
                CheckoutSessionId = session.Id,
                CheckoutUrl = session.Url
            }
        };
    }

    public async Task<ServiceResponse<List<UserDonation>>> GetUserDonationsAsync(string userId, int take = 20)
    {
        var response = new ServiceResponse<List<UserDonation>>();

        if (string.IsNullOrWhiteSpace(userId))
        {
            response.IsSuccessful = false;
            response.Message = "UserId is required.";
            return response;
        }

        take = Math.Clamp(take, 1, 200);

        await using var db = await _factory.CreateDbContextAsync();

        var donations = await db.UserDonations
            .AsNoTracking()
            .Where(x => x.AppUserId == userId)
            .OrderByDescending(x => x.CreatedUtc)
            .Take(take)
            .ToListAsync();

        response.IsSuccessful = true;
        response.Data = donations;
        return response;
    }

    // -----------------------
    // Helpers
    // -----------------------

    private ServiceResponse<CreateDonationCheckoutResponse> ValidateDonationRequest(CreateDonationCheckoutRequest request)
    {
        if (request is null)
            return new ServiceResponse<CreateDonationCheckoutResponse> { IsSuccessful = false, Message = "Request cannot be null." };

        if (string.IsNullOrWhiteSpace(request.AppUserId))
            return new ServiceResponse<CreateDonationCheckoutResponse> { IsSuccessful = false, Message = "AppUserId is required." };

        // Keep it simple + safe
        if (request.AmountDollars < 1 || request.AmountDollars > 500)
            return new ServiceResponse<CreateDonationCheckoutResponse> { IsSuccessful = false, Message = "Donation amount must be between $1 and $500." };

        // Optional, but helpful if you create customers
        if (string.IsNullOrWhiteSpace(request.Email))
            return new ServiceResponse<CreateDonationCheckoutResponse> { IsSuccessful = false, Message = "Email is required." };

        return new ServiceResponse<CreateDonationCheckoutResponse> { IsSuccessful = true };
    }

    private static string NormalizeCurrency(string? currency)
        => string.IsNullOrWhiteSpace(currency) ? "usd" : currency.Trim().ToLowerInvariant();

    private async Task<UserStripe> GetOrCreateUserStripeAsync(ApplicationDbContext db, string appUserId)
    {
        var map = await db.UserStripe.FirstOrDefaultAsync(x => x.AppUserId == appUserId);

        if (map is not null) return map;

        map = new UserStripe
        {
            AppUserId = appUserId,
            Status = AccountabilityStatus.Pending,
            CreatedUtc = DateTime.UtcNow,
            UpdatedUtc = DateTime.UtcNow
        };

        db.UserStripe.Add(map);
        await db.SaveChangesAsync();

        return map;
    }

    private async Task EnsureStripeCustomerAsync(ApplicationDbContext db, UserStripe map, string? email)
    {
        if (!string.IsNullOrWhiteSpace(map.StripeCustomerId))
            return;

        var customerService = new CustomerService(_stripeClient);

        var customer = await customerService.CreateAsync(new CustomerCreateOptions
        {
            Email = email,
            Metadata = new Dictionary<string, string>
            {
                ["app_user_id"] = map.AppUserId,
                ["purpose"] = "tcsa_donation"
            }
        });

        map.StripeCustomerId = customer.Id;
        map.UpdatedUtc = DateTime.UtcNow;

        await db.SaveChangesAsync();
    }

    private async Task<Session> CreateDonationCheckoutSessionAsync(string stripeCustomerId, UserDonation donation, string currency)
    {
        var sessionService = new SessionService(_stripeClient);

        // Success/Cancel pages must exist in your Blazor app
        var successUrl = $"{_stripeOptions.BaseUrl}/donate/success?session_id={{CHECKOUT_SESSION_ID}}";
        var cancelUrl = $"{_stripeOptions.BaseUrl}/donate/cancel";

        return await sessionService.CreateAsync(new SessionCreateOptions
        {
            Mode = "payment",
            Customer = stripeCustomerId,
            SuccessUrl = successUrl,
            CancelUrl = cancelUrl,

            LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    Quantity = 1,
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = currency,
                        UnitAmount = donation.AmountCents,
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Donation to The C# Academy"
                        }
                    }
                }
            },

            Metadata = new Dictionary<string, string>
            {
                ["type"] = "donation",
                ["donation_id"] = donation.Id.ToString(),
                ["app_user_id"] = donation.AppUserId,
                ["amount_cents"] = donation.AmountCents.ToString(),
                ["currency"] = currency
            }
        });
    }
}
