using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserById(string userId);
    Task<ApplicationUser> GetDetailedUserById(string userId);
    Task<ApplicationUser> GetUserProfileById(string userId);
    Task<BaseResponse> SaveProfile(ApplicationUser user);
}

public class UserService : IUserService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public UserService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }
    public async Task<ApplicationUser> GetUserProfileById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers.FirstOrDefaultAsync(x => x.Id.Equals(userId));
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<ApplicationUser> GetUserById(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.AspNetUsers
                .Include(x => x.Issues)
                .Include(x => x.DashboardProjects)
                .Include(x => x.UserActivity)
                    .AsSplitQuery()
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

    public async Task<BaseResponse> SaveProfile(ApplicationUser user)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var dbUser =  await context.AspNetUsers.FirstOrDefaultAsync(x => x.Id.Equals(user.Id));
                dbUser.DisplayName = user.DisplayName;
                dbUser.DiscordAlias = user.DiscordAlias;
                dbUser.GithubUsername = user.GithubUsername;
                dbUser.LinkedInUrl = user.LinkedInUrl;
                dbUser.Country = user.Country;
                dbUser.CodeWarsUsername = user.CodeWarsUsername;

                await context.SaveChangesAsync();

                return new BaseResponse
                {
                    Status = ResponseStatus.Success,
                    Message = "Profile updated successfully."
                };
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
    }

}
