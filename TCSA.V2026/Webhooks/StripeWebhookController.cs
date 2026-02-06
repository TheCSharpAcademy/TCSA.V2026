using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Enums;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Options;
using TCSA.V2026.Models;

namespace TCSA.V2026.Webhooks;

[ApiController]
[Route("api/stripe")]
public class StripeWebhookController(
    ApplicationDbContext _context,
    IOptions<StripeOptions> _stripeOptions,
    IStripeClient _stripeClient) : Controller
{
    [HttpPost("process-checkout")]
    public async Task<IActionResult> Webhook()
    {
        var json = await new StreamReader(Request.Body).ReadToEndAsync();
        Console.WriteLine(json);

        await _context.WebhookDebugLog.AddAsync(new WebhookDebugLog
        {
            Log = json,
            DateTime = DateTime.UtcNow,
            LogType = LogType.Debug,
        });

        await _context.SaveChangesAsync();

        var signatureHeader = Request.Headers["Stripe-Signature"];

        Event stripeEvent;

        try
        {
            stripeEvent = EventUtility.ConstructEvent(
                json,
                signatureHeader,
                _stripeOptions.Value.WebhookSigningSecret // "whsec_..."
            );
        }
        catch (Exception ex)
        {
            await _context.WebhookDebugLog.AddAsync(new WebhookDebugLog
            {
                Log = $"Error:{ex.Message}, Json: {json}",
                DateTime = DateTime.UtcNow,
                LogType = LogType.Debug,
            });

            await _context.SaveChangesAsync();
            return BadRequest();
        }

        if (stripeEvent.Type != "checkout.session.completed")
            return Ok();

        var session = stripeEvent.Data.Object as Session;
        if (session is null) return Ok();

        if (string.Equals(session.Mode, "setup", StringComparison.OrdinalIgnoreCase))
        {
            await HandleAccountabilitySetupAsync(session);
            return Ok();
        }

        if (string.Equals(session.Mode, "payment", StringComparison.OrdinalIgnoreCase))
        {
            await HandleDonationPaymentAsync(session);
        }

        return Ok();
    }

    private async Task HandleDonationPaymentAsync(Session session)
    {
        // Only handle donations you created (avoid accidental processing of other payments)
        if (session.Metadata is null ||
            !session.Metadata.TryGetValue("type", out var type) ||
            !string.Equals(type, "contribution", StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        // Find donation row
        var donationId = 0;
        if (session.Metadata.TryGetValue("contribution_id", out var donationIdRaw))
        {
            int.TryParse(donationIdRaw, out donationId);
        }

        if (donationId <= 0)
        {
            // fallback: lookup by checkout session id if you store it
            if (!string.IsNullOrWhiteSpace(session.Id))
            {
                var bySession = await _context.UserDonations
                    .FirstOrDefaultAsync(x => x.StripeCheckoutSessionId == session.Id);

                if (bySession is null) return;

                MarkDonationPaidIfNeeded(bySession, session.PaymentIntentId);
                await _context.SaveChangesAsync();
            }
            return;
        }

        var donation = await _context.UserDonations.FindAsync(donationId);
        if (donation is null) return;

        MarkDonationPaidIfNeeded(donation, session.PaymentIntentId);
        await _context.SaveChangesAsync();
    }

    private static void MarkDonationPaidIfNeeded(UserDonation donation, string? paymentIntentId)
    {
        if (donation.Status == DonationStatus.Succeeded)
            return;

        donation.Status = DonationStatus.Succeeded;
        donation.PaidUtc ??= DateTime.UtcNow;

        if (!string.IsNullOrWhiteSpace(paymentIntentId))
            donation.StripePaymentIntentId ??= paymentIntentId;
    }

    private async Task HandleAccountabilitySetupAsync(Session session)
    {
        var setupIntentId = session.SetupIntentId;
        if (string.IsNullOrWhiteSpace(setupIntentId)) return;

        var setupIntentService = new SetupIntentService(_stripeClient);
        var setupIntent = await setupIntentService.GetAsync(setupIntentId);

        var paymentMethodId = setupIntent.PaymentMethodId;
        var stripeCustomerId = setupIntent.CustomerId ?? session.CustomerId;

        int accountabilityProjectId = 0;
        if (setupIntent.Metadata is not null &&
            setupIntent.Metadata.TryGetValue("accountability_project_id", out var apIdRaw))
        {
            int.TryParse(apIdRaw, out accountabilityProjectId);
        }

        UserStripe? map = null;

        if (!string.IsNullOrEmpty(session.ClientReferenceId))
        {
            map = await _context.UserStripe.FirstOrDefaultAsync(x => x.AppUserId == session.ClientReferenceId);
        }
        else if (!string.IsNullOrWhiteSpace(stripeCustomerId))
        {
            map = await _context.UserStripe.FirstOrDefaultAsync(x => x.StripeCustomerId == stripeCustomerId);
        }

        if (map is not null)
        {
            if (string.IsNullOrWhiteSpace(map.StripePaymentMethodId) ||
                map.StripePaymentMethodId != paymentMethodId)
            {
                map.StripeCustomerId = stripeCustomerId ?? map.StripeCustomerId;
                map.StripePaymentMethodId = paymentMethodId;
                map.Status = AccountabilityStatus.Active;
                map.UpdatedUtc = DateTime.UtcNow;
            }
        }

        if (accountabilityProjectId > 0)
        {
            var ap = await _context.UserAccountabilityProjects.FindAsync(accountabilityProjectId);

            if (ap is not null)
            {
                ap.PaymentMethodConfirmedUtc ??= DateTime.UtcNow;
            }
        }

        await _context.SaveChangesAsync();
    }
}