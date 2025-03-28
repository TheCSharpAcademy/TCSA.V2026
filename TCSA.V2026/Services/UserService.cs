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
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.DashboardProjects)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
