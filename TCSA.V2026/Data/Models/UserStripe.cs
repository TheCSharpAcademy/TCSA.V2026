using TCSA.V2026.Data.Enums;

namespace TCSA.AccountabilityMate.Models;

public sealed class UserStripe
{
    public int Id { get; set; }

    public string AppUserId { get; set; }

    //[Required, MaxLength(255)]
    public string StripeCustomerId { get; set; } = string.Empty;

    // Filled after webhook (checkout.session.completed -> SetupIntent -> payment_method)
    //[MaxLength(255)]
    public string? StripePaymentMethodId { get; set; }

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    // Optional: helps you handle edge cases / retries / UI states
    //[MaxLength(50)]
    public AccountabilityStatus Status { get; set; }
}