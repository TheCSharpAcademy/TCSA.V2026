using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserForAdmin(string id);
}

public class UserService: IUserService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public UserService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<ApplicationUser> GetUserForAdmin(string id)
    {
        var startTime = DateTime.UtcNow;
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                 var result = await context.AspNetUsers
                .Include(u => u.DashboardProjects)
                .Include(u => u.CodeReviewProjects)
                .AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

                var loadTime = DateTime.UtcNow - startTime;
                return result;
            }
            
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
