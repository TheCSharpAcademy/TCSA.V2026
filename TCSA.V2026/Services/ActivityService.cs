//using Microsoft.AspNetCore.Components;
//using Microsoft.CodeAnalysis;
//using Microsoft.EntityFrameworkCore;
//using TCSA.V2026.Data;
//using TCSA.V2026.Data.Curriculum;
//using TCSA.V2026.Data.DTOs;
//using TCSA.V2026.Data.Models;
//using TCSA.V2026.Helpers;
//using static MudBlazor.CategoryTypes;

//namespace TCSA.V2026.Services;

//public interface IActivityService
//{
//    Task<List<ActivityDisplay>> GetUserActivity(string userId, int initialXP);
//}

//public class ActivityService : IActivityService
//{
//    private readonly IDbContextFactory<ApplicationDbContext> _factory;
//    private IChallengeService ChallengeService { get; set; }

//    public ActivityService(IDbContextFactory<ApplicationDbContext> factory, IChallengeService challengeService)
//    {
//        _factory = factory;
//        ChallengeService = challengeService;
//    }

//    public async Task<List<ActivityDisplay>> GetUserActivity(string userId, int initialXP)
//    {
//        try
//        {
//            using (var context = _factory.CreateDbContext())
//            {
//                var user = await context.Users
//                    .Include(u => u.UserActivity)
//                    .FirstOrDefaultAsync(u => u.Id == userId);
              
//                var issues = context.Issues.Where(i => i.AppUserId == userId).ToList();

//                var activityDisplay = await GetActivityDisplay(user.UserActivity, issues, user.Level, user.ExperiencePoints);

//                return activityDisplay;
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }

//        return null;
//    }

//    private async Task<List<ActivityDisplay>> GetActivityDisplay(
//        List<AppUserActivity> activities,
//        List<CommunityIssue> issues,
//        Level level,
//        int initialXP)
//    {
//        var activityDisplay = new List<ActivityDisplay>();
//        var currentXP = initialXP;
//        var issuesIds = issues.Select(i => i.ProjectId).ToList();
//        var challenges = await ChallengeService.GetChallenges(level);

//        foreach (var activity in activities)
//        {
//            var communityIssue = new CommunityIssue();
//            var challenge = new Challenge();

//            if (issuesIds.Contains(activity.ProjectId))
//            {
//                communityIssue = issues.FirstOrDefault(i => i.ProjectId == activity.ProjectId);
//            }

//            if (activity.ActivityType == ActivityType.ChallengeCompleted)
//            {
//                challenge = challenges.FirstOrDefault(c => c.Id == activity.ChallengeId);
//            }

//            var experiencePoints = ActivityHelper.GetXPs(issuesIds, activity, communityIssue, challenge);

//            activityDisplay.Add(new ActivityDisplay
//            {
//                Date = activity.DateSubmitted,
//                Description = ActivityHelper.GetDescription(issuesIds, activity, communityIssue, challenge),
//                ExperiencePoints = experiencePoints,
//                CurrentExperiencePoints = currentXP,
//                AppUserId = activity.AppUserId,
//                ActivityType = activity.ActivityType
//            });

//            currentXP -= experiencePoints;
//        }

//        return activityDisplay;
//    }
//}
