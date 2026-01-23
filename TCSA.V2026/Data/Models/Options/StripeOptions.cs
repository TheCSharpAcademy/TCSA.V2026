namespace TCSA.V2026.Data.Models.Options;

public sealed class StripeOptions
{
    public string ApiKey { get; set; } = string.Empty;
    public string BaseUrl { get; set; } = string.Empty;
    public string WebhookSigningSecret { get; set; } = string.Empty;
}