using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class PointsHelper
{
    public static PointsBreakdown GetPointBreakdown(ApplicationUser user)
    {
        var breakdown = new PointsBreakdown();

        List<Article> articles = ArticleHelper.GetArticles();
        List<Project> projects = ProjectHelper.GetProjects();
        List<Article> courseArticles = CourseHelper.GetCourses().SelectMany(c => c.Articles).ToList();

        List<int> completedIds = user.DashboardProjects.Where(x => x.IsCompleted).Select(x => x.ProjectId).ToList();

        List<int> codeReviewIds = user.CodeReviewProjects
            .Where(x => x.DashboardProject.IsCompleted || x.DashboardProject.IsArchived)
            .Select(x => x.DashboardProject.ProjectId).ToList();
        var reviewProjects = projects.Where(x => codeReviewIds.Contains(x.Id)).ToDictionary(x => x.Id, x => x.ExperiencePoints);

        breakdown.Articles = articles.Where(x => completedIds.Contains(x.Id)).Sum(x => x.ExperiencePoints);
        breakdown.Projects = projects.Where(x => completedIds.Contains(x.Id)).Sum(x => x.ExperiencePoints);
        breakdown.Reviews = codeReviewIds.Where(reviewProjects.ContainsKey).Sum(id => reviewProjects[id]);
        breakdown.Courses = courseArticles.Where(x => completedIds.Contains(x.Id)).Sum(x => x.ExperiencePoints);
        breakdown.Challenges = user.UserChallenges.Sum(x => x.Challenge.ExperiencePoints);
        breakdown.Issues = user.Issues.Where(x => x.IsClosed).Sum(x => x.ExperiencePoints);
        breakdown.Total = breakdown.Articles + breakdown.Projects + breakdown.Reviews + breakdown.Courses + breakdown.Challenges + breakdown.Issues;

        return breakdown;
    }
}