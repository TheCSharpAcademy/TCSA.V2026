using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class DashboardTaskDisplay
{
    public int Id { get; set; }
    public string IconUrl { get; set; }
    public string Title { get; set; }
    public TaskStatus Status { get; set; }
    public string Slug { get; set; }
    public string Url { get; set; }
    public Area Area { get; set; }
}

public enum TaskStatus
{
    NotCompleted,
    PendingReview,
    Completed
}
