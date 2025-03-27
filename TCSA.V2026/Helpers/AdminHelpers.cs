using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class AdminHelpers
{
    public static string GetActivityName(AppUserActivity activity)
    {
        if (activity.ActivityType == ActivityType.ArticleRead)
        {
            return ArticleHelper.GetArticles()
                   .FirstOrDefault(a => a.Id == activity.ProjectId)?.Title
               ?? CourseHelper.GetCourses().SelectMany(x => x.Articles)
                   .FirstOrDefault(a => a.Id == activity.ProjectId)?.Title; 
        }

        return "Unknown";
    }
}
