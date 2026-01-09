namespace TCSA.V2026.Data.Models;

public sealed class EnableAccountabilityRequest
{
    public string TcsaUserId { get; init; } = default!;
    public string? Email { get; init; }
    public int PledgeAmount { get; set; }
    public int DeadlineDays { get; set; }

    public int ProjectId { get; set; }
    public string? SuccessUrl { get; init; } = default!;
    public string? CancelUrl { get; init; } = default!;
}
