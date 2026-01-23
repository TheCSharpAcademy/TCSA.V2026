using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class FeedDisplay
{
    public int? ProjectId { get; set; }
    public ApplicationUser User { get; set; } = null!;
    public ActivityType ActivityType { get; set; }
    public string? ProjectName { get; set; }
    public string? ProjectIconUrl { get; set; }
    public Level? Level { get; set; }
    public DateTimeOffset Date { get; set; }
}
