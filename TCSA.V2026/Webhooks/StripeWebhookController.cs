using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Enums;
using TCSA.V2026.Data.Models.Options;

namespace TCSA.V2026.Webhooks;

[ApiController]
[Route("api/accountability")]
public class StripeWebhookController(
    ApplicationDbContext _context,
    IOptions<StripeOptions> _stripeOptions,
    IStripeClient _stripeClient) : Controller
{
    [HttpPost("webhook")]
    public async Task<IActionResult> Webhook()
    {
        var json = await new StreamReader(Request.Body).ReadToEndAsync();
        Console.WriteLine(json);

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
            return BadRequest();
        }

        if (stripeEvent.Type == "checkout.session.completed")
        {
            var session = stripeEvent.Data.Object as Session;
            if (session is null) return Ok();

            var setupIntentId = session.SetupIntentId;
            if (string.IsNullOrWhiteSpace(setupIntentId)) return Ok();

            var setupIntentService = new SetupIntentService(_stripeClient);
            var setupIntent = await setupIntentService.GetAsync(setupIntentId);

            var paymentMethodId = setupIntent.PaymentMethodId;
            var stripeCustomerId = setupIntent.CustomerId ?? session.CustomerId;

            Guid appUserId;

            if (Guid.TryParse(session.ClientReferenceId, out appUserId))
            {
                var map = await _context.UserStripe.FindAsync(appUserId);

                if (map is not null)
                {
                    map.StripeCustomerId = stripeCustomerId ?? map.StripeCustomerId;
                    map.StripePaymentMethodId = paymentMethodId;
                    map.Status = AccountabilityStatus.Active;
                    map.UpdatedUtc = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                }
            }
            else if (!string.IsNullOrWhiteSpace(stripeCustomerId))
            {
                var map = await _context.UserStripe
                    .FirstOrDefaultAsync(x => x.StripeCustomerId == stripeCustomerId);

                if (map is not null)
                {
                    map.StripePaymentMethodId = paymentMethodId;
                    map.Status = AccountabilityStatus.Active;
                    map.UpdatedUtc = DateTime.UtcNow;
                    await _context.SaveChangesAsync();
                }
            }
        }

        return Ok();
    }


}