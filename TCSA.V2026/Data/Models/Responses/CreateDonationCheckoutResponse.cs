namespace TCSA.V2026.Data.Models.Responses;

public sealed class CreateDonationCheckoutResponse
{
    public string CheckoutSessionId { get; set; } = string.Empty;
    public string CheckoutUrl { get; set; } = string.Empty;
}