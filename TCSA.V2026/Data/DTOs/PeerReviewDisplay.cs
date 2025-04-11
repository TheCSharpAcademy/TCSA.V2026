namespace TCSA.V2026.Data.DTOs;

public class PeerReviewDisplay
{
    public bool IsAssigned { get; set; }
    public string Title { get; set; }
    public string Name { get; set; }
    public string IconUrl { get; set; }
    public string GithubUrl { get; set; }
    public string AppUserId { get; set; }
    public int ExperiencePoints { get; set; }
    public int ProjectId { get; set; }
    public string ProjectSlug { get; set; }
    public int DashboardProjectId { get; set; }
    public TimeSpan DurationOpen { get; set; }
}
