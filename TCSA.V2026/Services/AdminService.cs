using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IAdminService
{
    Task<ApplicationUser> GetUserForAdmin(string id);
    Task<List<AdminEventDisplay>> GetAdminEvents();
    Task<List<AdminPendingDisplay>> GetAdminPendingProjects();
    Task<List<ApplicationUser>> SearchUser(string email);
}

public class AdminService : IAdminService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public AdminService(IDbContextFactory<ApplicationDbContext> factory)
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
               .Include(u => u.Issues)
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
    public async Task<List<AdminEventDisplay>> GetAdminEvents()
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.UserActivity
                    .Where(x => x.DateSubmitted >= DateTime.UtcNow.AddDays(-3))
                    .OrderByDescending(x => x.DateSubmitted)
                    .Select(ua => new AdminEventDisplay
                    {
                        AppUserId = ua.AppUserId,
                        ActivityType = ua.ActivityType,
                        Date = ua.DateSubmitted.AddHours(10).ToString("ddd, dd-MMM, HH:mm"),
                        ActivityName = DashboardProjectsHelpers.GetProject(ua.ProjectId).Title
                    })
                    .ToListAsync();
            }
        } 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public async Task<List<AdminPendingDisplay>> GetAdminPendingProjects()
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                return await context.DashboardProjects
                    .Include(p => p.AppUser)
                    .Where(p => !p.IsCompleted && !p.IsArchived)
                    .OrderByDescending(x => x.DateSubmitted)
                    .Select(ua => new AdminPendingDisplay
                    {
                        AppUserId = ua.AppUserId,
                        DashboardProjectId = ua.Id,
                        ProjectName = DashboardProjectsHelpers.GetProject(ua.ProjectId).Title,
                        DateSubmitted = ua.DateSubmitted.AddHours(10).ToString("ddd, dd-MMM, HH:mm"),
                        DateChangesRequested = ua.DateRequestedChange.AddHours(10).ToString("ddd, dd-MMM, HH:mm"),
                        UserName = ua.AppUser.UserName ?? ua.AppUser.DisplayName ?? ua.AppUser.Email
                    })
                    .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    public async Task<List<ApplicationUser>> SearchUser(string email)
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.AspNetUsers.Where(u => u.Email.Contains(email)).ToListAsync();
        }
    }
}
