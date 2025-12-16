using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Helpers;
using TCSA.V2026.Helpers.Constants;

namespace TCSA.V2026.Services;

public interface IFeedService
{
    Task<List<FeedDisplay>> GetRecentFeedItems();
    Task<PaginatedList<FeedDisplay>> GetPaginatedFeedItems(int pageNumber);
}

public class FeedService : IFeedService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly IUserService _userService;

    public FeedService(IDbContextFactory<ApplicationDbContext> factory, IUserService userService)
    {
        _factory = factory;
        _userService = userService;
    }

    public async Task<PaginatedList<FeedDisplay>> GetPaginatedFeedItems(int pageNumber)
    {
        using var context = _factory.CreateDbContext();

        var activitiesQuery = context.UserActivity
            .Include(ua => ua.ApplicationUser)
            .Where(ua => ua.ActivityType == ActivityType.NewBelt || ua.ActivityType == ActivityType.ProjectCompleted)
            .Select(ua => new
            {
                User = ua.ApplicationUser,
                ActivityType = ua.ActivityType,
                ProjectId = (int?)ua.ProjectId,
                Date = ua.DateSubmitted
            });

        var usersQuery = context.Users
            .Select(u => new
            {
                User = u,
                ActivityType = ActivityType.NewUser,
                ProjectId = (int?)null,
                Date = u.CreatedDate
            });

        var allItems = await activitiesQuery
            .Union(usersQuery)
            .OrderByDescending(f => f.Date)
            .AsNoTracking()
            .ToListAsync();

        var totalItems = allItems.Count;

        var pagedItems = allItems
            .Skip((pageNumber - 1) * PagingConstants.FeedPageSize)
            .Take(PagingConstants.FeedPageSize)
            .Select(f => new FeedDisplay
            {
                User = f.User,
                ActivityType = f.ActivityType,
                ProjectName = f.ProjectId.HasValue ? ProjectHelper.GetProjectName(f.ProjectId.Value) : null,
                ProjectIconUrl = f.ProjectId.HasValue ? ProjectHelper.GetProjectIconUrl(f.ProjectId.Value) : null,
                Date = f.Date
            })
            .ToList();

        return new PaginatedList<FeedDisplay>(pagedItems, totalItems, pageNumber, PagingConstants.FeedPageSize);
    }

    public async Task<List<FeedDisplay>> GetRecentFeedItems()
    {
        using var context = _factory.CreateDbContext();
        var recentActivitiesTask = context.UserActivity
            .Include(ua => ua.ApplicationUser)
            .Where(ua => ua.ActivityType == ActivityType.NewBelt || ua.ActivityType == ActivityType.ProjectCompleted)
            .OrderByDescending(ua => ua.DateSubmitted)
            .Take(FeedConstants.FeedWidgetItemLimits.RecentActivitiesLimit)
            .ToListAsync();

        var recentUsersTask = _userService.GetRecentlyJoinedUsers(FeedConstants.FeedWidgetItemLimits.RecentUsersLimit);

        await Task.WhenAll(recentActivitiesTask, recentUsersTask);

        var recentActivities = recentActivitiesTask.Result;
        var recentUsers = recentUsersTask.Result;

        var feedDisplays = new List<FeedDisplay>();
        foreach (var activity in recentActivities)
        {
            var feedItem = new FeedDisplay
            {
                User = activity.ApplicationUser,
                ActivityType = activity.ActivityType,
                Date = activity.DateSubmitted,
                ProjectIconUrl = ProjectHelper.GetProjectIconUrl(activity.ProjectId),
                ProjectName = ProjectHelper.GetProjectName(activity.ProjectId)
            };
            feedDisplays.Add(feedItem);
        }

        foreach (var user in recentUsers)
        {
            var feedItem = new FeedDisplay
            {
                User = user,
                ActivityType = ActivityType.NewUser,
                Date = user.CreatedDate
            };
            feedDisplays.Add(feedItem);
        }

        return feedDisplays.OrderByDescending(fd => fd.Date).ToList();
    }
}
