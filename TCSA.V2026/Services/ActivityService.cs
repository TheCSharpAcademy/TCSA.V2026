//using Microsoft.AspNetCore.Components;
//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
//using Microsoft.EntityFrameworkCore;
//using TCSA.V2026.Data;
//using TCSA.V2026.Data.Curriculum;
//using TCSA.V2026.Data.DTOs;
//using TCSA.V2026.Data.Models;
//using TCSA.V2026.Helpers;

//namespace TCSA.V2026.Services;

//public interface IActivityService
//{
//    Task<List<ActivityDisplay>> GetUserActivity(string userId, int initialXP);
//}

//public class ActivityService : IActivityService
//{
//    private readonly IDbContextFactory<ApplicationDbContext> _factory;

//    public ActivityService(IDbContextFactory<ApplicationDbContext> factory)
//    {
//        _factory = factory;
//    }

//    //public async Task<List<ActivityDisplay>> GetUserActivity(string userId, int initialXP)
//    //{
//    //    try
//    //    {
//    //        using (var context = _factory.CreateDbContext())
//    //        {
//    //            var activity = await context.UserActivity
//    //                .Where(a => a.AppUserId == userId)
//    //                .ToListAsync();

//    //            if(activity == null)
//    //            {
//    //                return new List<ActivityDisplay>();
//    //            }

//    //            var issues = context.Issues.Where(i => i.AppUserId == userId).ToList();

//    //            var activityDisplay = await GetActivityDisplay(activity, issues, initialXP);

//    //            return activityDisplay;
//    //        }
//    //    }
//    //    catch (Exception ex)
//    //    {
//    //        Console.WriteLine(ex.Message);
//    //    }

//    //    return null;
//    //}

//    //private async Task<List<ActivityDisplay> GetActivityDisplay(
//    //    List<AppUserActivity> activities,
//    //    List<CommunityIssue> issues,
//    //    int initialXP)
//    //{
//    //    var activityDisplay = new List<ActivityDisplay>();
//    //    var currentXP = initialXP;
//    //    var issuesIds = issues.Select(i => i.ProjectId).ToArray();

//    //    foreach (var activity in activities)
//    //    {
//    //        var communityIssue = new CommunityIssue();
//    //        var challenge = new Challenge();

//    //            if (issuesIds.Contains(activity.ProjectId))
//    //            {
//    //                communityIssue = issues.FirstOrDefault(i => i.ProjectId == activity.ProjectId);
//    //            }

//    //            if (activity.ActivityType == ActivityType.ChallengeCompleted)
//    //            {
//    //                challenge = await ChallengeService.GetChallengeById(activity.ChallengeId);
//    //            }

//    //            var experiencePoints = GetXPs(activity, communityIssue, challenge);

//    //            activityDisplay.Add(new ActivityDisplay
//    //            {
//    //                Date = activity.DateSubmitted,
//    //                Description = await GetDescriptionMarkup(activity, activity.AppUserId, communityIssue, challenge),
//    //                ExperiencePoints = GetXPs(activity, communityIssue, challenge),
//    //                CurrentExperiencePoints = currentXP,
//    //                AppUserId = activity.AppUserId,
//    //                ActivityType = activity.ActivityType
//    //            });

//    //            currentXP -= experiencePoints;
//    //    }
//    //}

//    //private async Task<MarkupString> GetDescriptionMarkup(
//    //    AppUserActivity item, string userId, 
//    //    CommunityIssue? issue = null, 
//    //    Challenge? challenge = null)
//    //{
//    //    var description = ActivityHelper.GetDescription(issuesIds, item, issue, challenge);
//    //    return new MarkupString(description);
//    //}

//    //public int GetXPs(
//    //    AppUserActivity item, 
//    //    CommunityIssue? issue = null, 
//    //    Challenge? challenge = null)
//    //{
//    //    if (item.ActivityType == ActivityType.ProjectSubmitted || item.ActivityType == ActivityType.IssueSubmitted)
//    //    {
//    //        return 0;
//    //    }

//    //    if (item.ActivityType == ActivityType.ChallengeCompleted)
//    //    {
//    //        return challenge.ExperiencePoints;
//    //    }

//    //    if (issuesIds.Contains(item.ProjectId))
//    //    {
//    //        return issue.ExperiencePoints;
//    //    }

//    //    else if (item.ActivityType == ActivityType.ArticleRead)
//    //    {
//    //        var articles = ArticleHelper.GetArticles().ToList();
//    //        var courseArticles = CourseHelper.GetCourses().SelectMany(x => x.Articles).ToList();
//    //        articles.AddRange(courseArticles);

//    //        return articles.Single(x => x.Id == item.ProjectId).ExperiencePoints;
//    //    }

//    //    return ProjectHelper.GetProjects().Single(x => x.Id == item.ProjectId).ExperiencePoints;
//    //}

//    //private string GetDescription(int projectId)
//    //{
//    //    var title = DashboardProjectsHelpers.GetProject(projectId).Title;
//    //    throw new NotImplementedException();
//    //}
//}
