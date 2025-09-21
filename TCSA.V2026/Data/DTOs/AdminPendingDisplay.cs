namespace TCSA.V2026.Data.DTOs;

public class AdminPendingDisplay
{
    public string DateSubmitted { get; set; }
    public string DateChangesRequested { get; set; }
    public string AppUserId { get; set; }
    public int DashboardProjectId { get; set; }
    public string UserName { get; set; }
    public string ReviewerName { get; set; }
    public string ProjectName { get; set; }
}
