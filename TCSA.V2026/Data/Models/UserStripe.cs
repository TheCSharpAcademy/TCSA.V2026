using TCSA.V2026.Data.Enums;

namespace TCSA.V2026.Data.Models;

public sealed class UserStripe
{
    public int Id { get; set; }

    public string AppUserId { get; set; }

    public string StripeCustomerId { get; set; } = string.Empty;

    public string? StripePaymentMethodId { get; set; }

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public AccountabilityStatus Status { get; set; }
}