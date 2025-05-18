using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IProjectService
{
    Task<BaseResponse> MarkAsCompleted(int projectId);
    Task<bool> IsProjectCompleted(string userId, int projectId);
    Task<List<int>> GetCompletedProjectsById(string userId);
    Task<BaseResponse> PostArticle(int projectId, string userId, string url);
    }

public class ProjectService : IProjectService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public ProjectService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<int>> GetCompletedProjectsById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .Where(x => x.AppUserId == userId && x.IsCompleted)
                    .Select(x => x.ProjectId)
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<BaseResponse> PostArticle(int projectId, string userId, string url)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var project = await context.DashboardProjects
                .FirstOrDefaultAsync(dp => dp.ProjectId == projectId && dp.AppUserId == userId && !dp.IsArchived);

                if (project == null)
                {
                    await context.DashboardProjects.AddAsync(new DashboardProject
                    {
                        ProjectId = projectId,
                        AppUserId = userId,
                        IsCompleted = false,
                        IsArchived = false,
                        IsPendingNotification = false,
                        IsPendingReview = true,
                        DateSubmitted = DateTime.UtcNow,
                        GithubUrl = url
                    });
                    await context.SaveChangesAsync();
                }
            }
        }
        catch (Exception ex)
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = ex.Message
            };
        }

        return new BaseResponse();
    }

    public async Task<bool> IsProjectCompleted(string userId, int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .AnyAsync(
                        x => x.IsCompleted
                        && x.ProjectId == projectId
                        && x.AppUserId == userId
                    );
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<BaseResponse> MarkAsCompleted(int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var project = context.DashboardProjects
                    .Include(dp => dp.AppUser)
                    .FirstOrDefault(p => p.Id == projectId);

                if (project == null)
                {
                    return new BaseResponse
                    {
                        Status = ResponseStatus.Fail,
                        Message = "Project Not Found"
                    };
                }

                project.IsCompleted = true;
                project.DateCompleted = DateTime.UtcNow;

                var experiencePoints = DashboardProjectsHelpers.GetProject(project.ProjectId).ExperiencePoints;

                context.UserActivity.Add(new AppUserActivity
                {
                    AppUserId = project.AppUser.Id,
                    ProjectId = project.ProjectId,
                    DateSubmitted = DateTime.UtcNow,
                    ActivityType = ActivityType.ProjectCompleted
                });

                context.Users.Attach(project.AppUser);
                project.AppUser.ExperiencePoints += experiencePoints;
                context.Entry(project.AppUser).Property(u => u.ExperiencePoints).IsModified = true;

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

