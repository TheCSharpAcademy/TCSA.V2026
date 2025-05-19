using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IPeerReviewService
{
    Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId);
    Task<ApplicationUser> GetUserForPeerReview(string reviewerId);
    Task<List<PeerReviewDisplay>> GetProjectsForPeerReview(string userId);
    Task<BaseResponse> AssignUserToCodeReview(string userId, int id);
    Task<BaseResponse> ReleaseUserFromCodeReview(string userId, int id);
    Task<BaseResponse> MarkCodeReviewAsCompleted(string reviewerId, int dashboardProjectId, string userId);
}
public class PeerReviewService : IPeerReviewService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public PeerReviewService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<BaseResponse> AssignUserToCodeReview(string userId, int id)
    {
        var result = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                await context.UserReviews.AddAsync(new UserReview
                {
                    AppUserId = userId,
                    DashboardProjectId = id
                });

                await context.SaveChangesAsync();
            }

            return result;
        } 
        catch (Exception ex)
        {
            result.Message = ex.Message;
            result.Status = ResponseStatus.Fail;
            return result;
        }
    }

    public async Task<BaseResponse> ReleaseUserFromCodeReview(string userId, int id)
    {
        var result = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var userReview = await context.UserReviews
                    .FirstOrDefaultAsync(x => x.AppUserId == userId && x.DashboardProjectId == id);

                if (userReview is null)
                {
                    result.Message = "User is Null";
                    result.Status = ResponseStatus.Fail;
                    return result;
                }

                context.UserReviews.Remove(userReview);
                await context.SaveChangesAsync();
            }

            return result;
        }
        catch (Exception ex)
        {
            result.Message = ex.Message;
            result.Status = ResponseStatus.Fail;
            return result;
        }
    }

    public async Task<ApplicationUser> GetUserForPeerReview(string reviewerId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                    .Include(x => x.CodeReviewProjects)
                    .FirstOrDefaultAsync(x => x.Id.Equals(reviewerId));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<PeerReviewDisplay>> GetProjectsForPeerReview(string userId)
    {
        var url = "https://github.com/TheCSharpAcademy/CodeReviews";
        var beginnerProjects = new List<int> { 53, 11, 12, 13 };

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var user = await context.AspNetUsers
                    .Include(x => x.CodeReviewProjects)
                    .FirstOrDefaultAsync(x => x.Id.Equals(userId));
                var level = user.Level;

                if (level < Level.Yellow)
                {
                    return new List<PeerReviewDisplay> { };
                }
                else if (level > Level.Yellow)
                {
                    beginnerProjects.AddRange(new List<int> { 14, 15, 16, 17 });
                }

                if (level > Level.Red)
                {
                    beginnerProjects.AddRange(new List<int> { 18, 19, 20, 21 });
                }

                var reviewProjects = context.UserReviews
                    .Where(x => x.AppUserId != user.Id)
                    .Select(x => x.DashboardProjectId)
                    .ToList();

                var projects = await context.DashboardProjects
                .AsSplitQuery()
                .Include(x => x.AppUser)
                .Where(x => x.IsPendingReview
                   && beginnerProjects.Contains(x.ProjectId)
                   && !reviewProjects.Contains(x.Id)
                   && x.GithubUrl.StartsWith(url))
                .OrderBy(x => x.DateSubmitted)
                .ToListAsync();

                var result = PeerReviewHelpers.MapPeerReviewDisplays(projects, user.CodeReviewProjects);

                return result;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var result = await context.UserReviews
                    .Where(x => x.AppUserId == userId)
                    .Select(review => new
                    {
                        review.DashboardProject.ProjectId,
                        review.DashboardProject.IsCompleted,
                        review.DashboardProject.IsArchived,
                        UserName = review.DashboardProject.AppUser.FirstName + " " + review.DashboardProject.AppUser.LastName
                    })
                    .Where(project => project.ProjectId != null)
                    .Select(project => new CodeReviewDetail
                    {
                        ProjectId = project.ProjectId,
                        IsCompleted = project.IsCompleted || project.IsArchived,
                        UserName = project.UserName
                    })
                    .ToListAsync();

                return result;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<BaseResponse> MarkCodeReviewAsCompleted(string reviewerId, int dashboardProjectId, string userId)
    {
        var result = new BaseResponse();

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var currentRevieweePoints = context.Users
                    .Where(x => x.Id == userId)
                    .Select(x => x.ExperiencePoints)
                    .FirstOrDefault();

                var currentReviewerPoints = context.Users
                   .Where(x => x.Id == reviewerId)
                   .Select(x => x.ExperiencePoints)
                   .FirstOrDefault();

                var reviewedProjects = await context.UserActivity
                    .Where(x => x.AppUserId.ToString() == reviewerId && x.ActivityType == ActivityType.CodeReviewCompleted)
                    .ToListAsync();

                var dashboardProject = await context.DashboardProjects.FirstOrDefaultAsync(x => x.Id == dashboardProjectId);

                var academyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == dashboardProject.ProjectId);

                dashboardProject.IsPendingReview = false;
                dashboardProject.IsPendingNotification = true;
                dashboardProject.IsCompleted = true;

                context.DashboardProjects
                    .Update(dashboardProject);

                context.UserActivity.AddRange(
                    new AppUserActivity
                    {
                        ProjectId = dashboardProject.ProjectId,
                        AppUserId = dashboardProject.AppUserId,
                        DateSubmitted = DateTime.UtcNow,
                        ActivityType = ActivityType.ProjectCompleted
                    },
                    new AppUserActivity
                    {
                        ProjectId = dashboardProject.ProjectId,
                        AppUserId = reviewerId,
                        DateSubmitted = DateTime.UtcNow,
                        ActivityType = ActivityType.CodeReviewCompleted
                    }
                );

                var reviewer = await context.Users
                    .Where(x => x.Id == reviewerId).FirstAsync();

                if (reviewer != null 
                    && reviewedProjects != null 
                    && reviewer.ReviewExperiencePoints == 0 
                    && reviewedProjects.Count > 0)
                {
                    //This has to be retroactive, so if some user has reviews but no points, it will calculate them first.
                    //This is the same as the leaderboard calculation, but just in case the leaderboard calculation is never done and some user escapes the check, we make sure that the points are set here.
                    foreach (AppUserActivity review in reviewedProjects)
                    {
                        var reviewAcademyProject = ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == review.ProjectId);

                        reviewer.ReviewExperiencePoints = reviewer.ReviewExperiencePoints + reviewAcademyProject.ExperiencePoints;
                    }
                    //If reviewer has no experience points set, that means the reviewedProjects column is also not set yet.
                    reviewer.ReviewedProjects = reviewedProjects.Count;
                }

                context.Users
                    .Where(x => x.Id == dashboardProject.AppUserId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentRevieweePoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, academyProject.ExperiencePoints + currentReviewerPoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ReviewExperiencePoints, academyProject.ExperiencePoints + reviewer.ReviewExperiencePoints));

                context.Users
                    .Where(x => x.Id == reviewerId)
                    .ExecuteUpdate(y => y.SetProperty(u => u.ReviewedProjects, reviewer.ReviewedProjects + 1));

                await context.SaveChangesAsync();

                return result;
            }
        }
        catch (Exception ex)
        {
            result.Message = ex.Message;
            result.Status = ResponseStatus.Fail;
            return result;
        }
    }
}
