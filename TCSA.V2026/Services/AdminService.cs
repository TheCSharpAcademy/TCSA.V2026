using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IAdminService
{
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

    public async Task<List<AdminEventDisplay>> GetAdminEvents()
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

    public async Task<List<AdminPendingDisplay>> GetAdminPendingProjects()
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.DashboardProjects
                .Include(p => p.AppUser)
                .Where(p => !p.IsCompleted)
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

    public async Task<List<ApplicationUser>> SearchUser(string email)
    {
        using (var context = _factory.CreateDbContext())
        {
            return await context.AspNetUsers.Where(u => u.Email.Contains(email)).ToListAsync();
        }
    }
}
