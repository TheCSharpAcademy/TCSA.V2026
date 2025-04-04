using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface ICommunityService
{
    Task<CommunityIssue> GetIssueByProjectId(int projectId);
    Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId);
    Task<BaseResponse> AssignUserToIssue(string appUserId, CommunityIssue issue);
    Task<BaseResponse> SubmitIssueToReview(int issueId, string githubUrl);
}

public class CommunityService : ICommunityService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public CommunityService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<BaseResponse> AssignUserToIssue(string appUserId, CommunityIssue issue)
    {
        var result = new BaseResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                await context.DashboardProjects.AddAsync(new DashboardProject
                {
                    GithubUrl = string.Empty,
                    AppUserId = appUserId,
                    ProjectId = issue.ProjectId,
                    DateSubmitted = DateTime.UtcNow,
                });

                await context.Issues.Where(x => x.ProjectId == issue.ProjectId)
                     .ExecuteUpdateAsync(y => y.SetProperty(u => u.AppUserId, appUserId));

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
    public async Task<BaseResponse> SubmitIssueToReview(int issueId, string githubUrl)
    {
        var result = new BaseResponse();
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var project = context.DashboardProjects.FirstOrDefault(context => context.ProjectId == issueId);  

                project.GithubUrl = githubUrl;
                project.IsPendingReview = true;

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
    public async Task<List<CommunityIssue>> GetAvailableIssuesForCommunityPage(string appUserId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues
                    .Where(i => !i.IsClosed)
                    .Where(i => string.IsNullOrEmpty(i.AppUserId) || i.AppUserId.Equals(appUserId))
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
    public async Task<CommunityIssue> GetIssueByProjectId(int projectId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.Issues.FirstOrDefaultAsync(x => x.ProjectId == projectId);
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
