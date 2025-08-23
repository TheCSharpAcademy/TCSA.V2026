using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface IGithubService
{
    Task<BaseResponse> MarkAsCompleted(int projectId, int pullRequestNumber);
}

public class GithubService : IGithubService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public GithubService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<BaseResponse> MarkAsCompleted(int projectId, int pullRequestNumber)
    {
        var points = ProjectHelper.GetProjects().FirstOrDefault(p => p.Id == projectId).ExperiencePoints;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var project = await context.DashboardProjects
                    .Include(p => p.AppUser)
                       .ThenInclude(u => u.UserActivity)
                    .FirstOrDefaultAsync(p => p.ProjectId == projectId && p.GithubUrl.Contains(pullRequestNumber.ToString()));

                project.IsPendingNotification = true;
                project.IsPendingReview = false;
                project.IsCompleted = true;
                project.DateCompleted = DateTimeOffset.UtcNow;

                project.AppUser.ExperiencePoints = project.AppUser.ExperiencePoints + points;
                project.AppUser.UserActivity.Add(new AppUserActivity
                {
                    ActivityType = ActivityType.ProjectCompleted,
                    ProjectId = project.ProjectId,
                    DateSubmitted = DateTimeOffset.UtcNow
                });

                var review = await context.UserReviews
                    .Include(x => x.User)
                        .ThenInclude(u => u.UserActivity)
                    .FirstOrDefaultAsync(r => r.DashboardProjectId == project.Id);

                if (review != null)
                {
                    review.User.ExperiencePoints = review.User.ExperiencePoints + points;
                    review.User.ReviewedProjects = review.User.ReviewedProjects + 1;
                    review.User.UserActivity.Add(new AppUserActivity
                    {
                        ActivityType = ActivityType.CodeReviewCompleted,
                        ProjectId = project.ProjectId,
                        DateSubmitted = DateTimeOffset.UtcNow
                    });
                }

                await context.SaveChangesAsync();
            }
            return new BaseResponse
            {
                Status = ResponseStatus.Success,
            };
        }
        catch (Exception ex)
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = ex.Message
            };
        }
    }
}