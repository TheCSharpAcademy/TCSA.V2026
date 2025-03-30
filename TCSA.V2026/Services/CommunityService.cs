using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface ICommunityService
{
    Task<CommunityIssue> GetIssueByProjectId(int projectId);
}

public class CommunityService : ICommunityService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public CommunityService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
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
