using Microsoft.CodeAnalysis;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class ActivityHelper
{
    public static List<ActivityDisplay> GetActivityDisplay(ApplicationUser user)
    {
        var activityDisplay = new List<ActivityDisplay>();
        var currentXP = user.ExperiencePoints;
        var issuesIds = user.Issues.Select(user => user.Id).ToList();

        foreach (var item in user.UserActivity)
        {
            try
            {
                Console.WriteLine("ProjectId = " + item.ProjectId);
                Console.WriteLine(item.ActivityType);
                var communityIssue = new CommunityIssue();
                var challenge = new Challenge();

                if (issuesIds.Contains(item.ProjectId))
                {
                    communityIssue = user.Issues.FirstOrDefault(x => x.Id == item.ProjectId);
                }

                if (item.ActivityType == ActivityType.ChallengeCompleted)
                {
                    challenge = user.UserChallenges.FirstOrDefault(c => c.ChallengeId == item.ChallengeId).Challenge;
                }

                var experiencePoints = GetXPs(issuesIds, item, communityIssue, challenge);

                activityDisplay.Add(new ActivityDisplay

                {
                    Date = item.DateSubmitted,
                    Description = GetDescription(issuesIds, item, communityIssue, challenge),
                    ExperiencePoints = GetXPs(issuesIds, item, communityIssue, challenge),
                    CurrentExperiencePoints = currentXP,
                    AppUserId = item.AppUserId,
                    ActivityType = item.ActivityType
                });

                currentXP -= experiencePoints;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ProjectId error = {item.ProjectId}" + ex.Message + ex.StackTrace);
            }
        }

        return activityDisplay;
    }

    public static int GetXPs(List<int> issuesIds, AppUserActivity item, CommunityIssue? issue = null, Challenge? challenge = null)
    {
        if (item.ActivityType == ActivityType.ProjectSubmitted || item.ActivityType == ActivityType.IssueSubmitted)
        {
            return 0;
        }

        if (item.ActivityType == ActivityType.ChallengeCompleted)
        {
            return challenge.ExperiencePoints;
        }

        if (issuesIds.Contains(item.ProjectId))
        {
            return issue.ExperiencePoints;
        }

        else if (item.ActivityType == ActivityType.ArticleRead)
        {
            var articles = ArticleHelper.GetArticles().ToList();
            var courseArticles = CourseHelper.GetCourses().SelectMany(x => x.Articles).ToList();
            articles.AddRange(courseArticles);

            return articles.FirstOrDefault(x => x.Id == item.ProjectId)?.ExperiencePoints ?? 0;
        }

        return ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == item.ProjectId)?.ExperiencePoints ?? 0;
    }

    public static string GetDescription(List<int> issuesIds, AppUserActivity item, CommunityIssue? issue = null, Challenge? challenge = null)
    {
        var articles = ArticleHelper.GetArticles().ToList();
        var courseArticles = CourseHelper.GetCourses().SelectMany(x => x.Articles).ToList();
        articles.AddRange(courseArticles);

        switch (item.ActivityType)
        {
            case ActivityType.ArticleRead:
                return $"You read the article <b>{articles.Single(x => x.Id == item.ProjectId).Title}</b>";
            case ActivityType.ProjectSubmitted:
                return $"You submitted the project <b>{ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == item.ProjectId)?.Title}</b> for review.";
            case ActivityType.IssueSubmitted:
                return $"You submitted the issue <b>{issue.Title}</b> for review.";
            case ActivityType.ProjectCompleted:
                return GetTitle(issuesIds, item, issue);
            case ActivityType.CodeReviewCompleted:
                return $"You've finished a code review for a <b>{ProjectHelper.GetProjects().FirstOrDefault(x => x.Id == item.ProjectId)?.Title}</b> project.";
            case ActivityType.ChallengeCompleted:
                return $"You've completed the challenge <b>{challenge.Name}</b>.";
            default:
                return "";
        }
    }

    public static string GetTitle(List<int> issuesIds, AppUserActivity item, CommunityIssue? issue = null)
    {
        if (issuesIds.Contains(item.ProjectId))
        {
            return $"The open source ticket <b>{issue.Title}</b> was marked as complete.";
        }

        Console.WriteLine("ProjectId = " + item.ProjectId);
        return $"The project <b>{ProjectHelper.GetProjects().Single(x => x.Id == item.ProjectId).Title}</b> was marked as complete.";
    }
}
