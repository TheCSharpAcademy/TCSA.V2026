using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class PeerReviewHelpers
{
    public static List<PeerReviewDisplay> MapPeerReviewDisplays(List<DashboardProject> dashboardProjects, List<UserReview> reviews)
    {
        var result = new List<PeerReviewDisplay>();
        var projects = ProjectHelper.GetProjects();

        foreach (var dp in dashboardProjects)
        {
            var project = projects.FirstOrDefault(p => p.Id == dp.ProjectId);
            result.Add(new PeerReviewDisplay
            {
                DashboardProjectId = dp.Id,
                IsAssigned = reviews.Any(x => x.DashboardProjectId == dp.Id),
                Title = project.Title,
                IconUrl = project.IconUrl,
                ProjectId = dp.ProjectId,
                ProjectSlug = project.Slug,
                Name = GetRevieweeName(dp.AppUser),
                ExperiencePoints = project.ExperiencePoints,
                GithubUrl = dp.GithubUrl,
                DurationOpen = DateTime.UtcNow - dp.DateSubmitted
            });
        }

        return result;
    }

    public static string GetRevieweeName(ApplicationUser user)
    {
        var displayName = 
            string.IsNullOrEmpty(user.DisplayName) 
            ? user.FirstName + " " + user.LastName 
            : user.DisplayName;

        var githubUsername = string.IsNullOrEmpty(user.GithubUsername) ? "" : user.GithubUsername;

        return displayName == " " ? githubUsername : displayName;   
    }
}
