using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface IUserService
{
    Task<ApplicationUser> GetUserById(string userId);
    Task<ApplicationUser> GetDetailedUserById(string userId);
    Task<BaseResponse> SaveProfile(ApplicationUser user);
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
                .Include(x => x.UserActivity)
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
            using var context = _factory.CreateDbContext();

            context.AspNetUsers.Update(user); 
            await context.SaveChangesAsync(); 

            return new BaseResponse
            {
                Status = ResponseStatus.Success,
                Message = "Profile updated successfully."
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
