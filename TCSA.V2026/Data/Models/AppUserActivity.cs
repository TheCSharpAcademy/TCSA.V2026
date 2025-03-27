namespace TCSA.V2026.Data.Models;

public class AppUserActivity
{
    public int Id { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public string AppUserId { get; set; }
    public int ProjectId { get; set; }
    public int ChallengeId { get; set; }
    public DateTimeOffset DateSubmitted { get; set; }
    public ActivityType ActivityType { get; set; }
}

public enum ActivityType
{
    ArticleRead,
    ProjectSubmitted,
    ProjectCompleted,
    CodeReviewCompleted,
    IssueSubmitted,
    ChallengeCompleted
}

