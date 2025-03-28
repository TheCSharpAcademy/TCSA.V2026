using Microsoft.CodeAnalysis;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class DashboardProjectsHelpers
{
    public static Article GetProject(int projectId)
    {
        return ArticleHelper.GetArticles().FirstOrDefault(a => a.Id == projectId)
            ?? ProjectHelper.GetProjects().FirstOrDefault(p => p.Id == projectId)
            ?? CourseHelper.GetCourses().SelectMany(x => x.Articles).FirstOrDefault(a => a.Id == projectId);
    }
}
