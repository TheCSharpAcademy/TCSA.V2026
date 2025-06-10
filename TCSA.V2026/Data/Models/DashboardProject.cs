using System.ComponentModel.DataAnnotations.Schema;

namespace TCSA.V2026.Data.Models;

public class DashboardProject
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string GithubUrl { get; set; }
    public string AppUserId { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsArchived { get; set; }
    public bool IsPendingNotification { get; set; }
    public bool IsPendingReview { get; set; }
    public DateTimeOffset DateSubmitted { get; set; }
    public DateTimeOffset DateRequestedChange { get; set; }
    public DateTimeOffset? DateCompleted { get; set; }
    public TimeSpan? ReviewTime
    {
        get
        {
            if (DateCompleted.HasValue)
            {
                return DateCompleted.Value - DateRequestedChange;
            }

            return null;
        }
    }
    public ApplicationUser AppUser { get; set; }

    [NotMapped]
    public string? Reviewer { get; set; }
}

public enum ProjectType
{
    CurriculumArticle,
    CourseArticle,
    Article,
    Project,
    Issue,
    CodeReview
}
