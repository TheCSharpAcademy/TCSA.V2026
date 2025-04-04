using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserById(string userId);
    Task<ApplicationUser> GetDetailedUserById(string userId);
}

public class UserService: IUserService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public UserService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<ApplicationUser> GetUserById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.DashboardProjects)
                .FirstOrDefaultAsync(x => x.Id.Equals(userId));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<ApplicationUser> GetDetailedUserById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.UserActivity)
                .Include(x => x.DashboardProjects)
                .Include(x => x.Issues)
                .Include(x => x.UserChallenges)
                    .ThenInclude(x => x.Challenge)
                .AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id.Equals(userId));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
