using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class ActivityDisplay
{
    public int ActivityId { get; set; }
    public ActivityType ActivityType { get; set; }
    public DateTimeOffset Date { get; set; }
    public string Time { get; set; }
    public string Description { get; set; }
    public string AppUserId { get; set; }
    public int ExperiencePoints { get; set; }
    public int CurrentExperiencePoints { get; set; }
    public bool IsDuplicate { get; set; } = false;
}
