using System.Diagnostics;
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

    public static string GetProjectName(DashboardProject project)
    {
            return
                  ArticleHelper.GetArticles()
                   .FirstOrDefault(a => a.Id == project.ProjectId)?.Title
               ?? ProjectHelper.GetProjects()
                   .FirstOrDefault(p => p.Id == project.ProjectId)?.Title
               ?? CourseHelper.GetCourses().SelectMany(x => x.Articles)
                   .FirstOrDefault(a => a.Id == project.ProjectId)?.Title;
    }
}
