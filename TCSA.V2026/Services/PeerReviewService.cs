using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface IPeerReviewService
{
    Task<List<CodeReviewDetail>> GetCodeReviewDetails(string userId);
}
public class PeerReviewService : IPeerReviewService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public PeerReviewService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    // TODO CHANGE THIS, LOOKS LIKE A VERY EXPENSIVE QUERY
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
}
