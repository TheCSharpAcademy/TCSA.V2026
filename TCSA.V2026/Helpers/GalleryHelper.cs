using System.Text.RegularExpressions;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class GalleryHelper
{
    public static string GalleryVideoUrlFormatter(string url)
    {
        return url.Replace("watch?v=", "embed/");
    }

    public static bool YouTubeUrlValidator(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        string pattern = @"^https:\/\/www\.youtube\.com\/watch\?v=.+$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(url);
    }

    public static ShowcaseItemDTO ConvertToDTO(ShowcaseItem item)
    {
        var projectsHelper = ProjectHelper.GetProjectInfos().AsQueryable();

        return new ShowcaseItemDTO
        {
            Id = item.Id,
            ApplicationUserId = item.AppUserId,
            ProjectId = item.DashboardProject?.ProjectId ?? 0,
            DashboardProjectId = item.DashboardProject?.Id ?? 0,
            Username = string.IsNullOrEmpty(item.ApplicationUser?.FirstName)
                ? item.ApplicationUser?.UserName
                : $"{item.ApplicationUser.FirstName} {item.ApplicationUser.LastName}",
            Area = projectsHelper.FirstOrDefault(p => p.Id == item.DashboardProject.ProjectId)!.Area,
            VideoUrl = item.VideoUrl,
            GithubUrl = item.GithubUrl,
            ProjectName = projectsHelper.FirstOrDefault(p => p.Id == item.DashboardProject.ProjectId)?.Title ?? ""
        };
    }

    public static string GetProjectTitle(IEnumerable<ShowcaseProjectInfo> projects, int projectId)
    {
        var project = projects.FirstOrDefault(p => p.Id == projectId);
        return project?.Title ?? projectId.ToString();
    }
}
