using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class AdminEventDisplay
{
    public string Date { get; set; }
    public ActivityType ActivityType { get; set; }
    public string AppUserId { get; set; }
    public string ActivityName { get; set; }
}
