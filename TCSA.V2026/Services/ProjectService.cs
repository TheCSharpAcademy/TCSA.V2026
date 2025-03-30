using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IProjectService
{
    Task<BaseResponse> MarkAsCompleted(int projectId);
}
public class ProjectService : IProjectService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public ProjectService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
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

