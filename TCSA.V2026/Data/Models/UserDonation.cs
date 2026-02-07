using TCSA.V2026.Data.Enums;

namespace TCSA.V2026.Data.Models;

public sealed class UserDonation
{
    public int Id { get; set; }

    public string AppUserId { get; set; } = "";     // FK to AspNetUsers.Id (string)
    public int AmountCents { get; set; }
    public string Currency { get; set; } = "usd";

    public DonationStatus Status { get; set; } = DonationStatus.Created;

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? PaidUtc { get; set; }

    // Stripe references for debugging + reconciliation
    public string StripeCheckoutSessionId { get; set; } = "";
    public string? StripePaymentIntentId { get; set; }
}
