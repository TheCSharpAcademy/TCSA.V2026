using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TCSA.V2026.Data.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? DiscordAlias { get; set; }
    public string? CodeWarsUsername { get; set; }
    public string? LinkedInUrl { get; set; }
    public string? GithubUsername { get; set; }
    public string? DisplayName { get; set; }
    public string Country { get; set; }
    public int ExperiencePoints { get; set; }
    public int ReviewExperiencePoints { get; set; }
    public int ReviewedProjects { get; set; }
    public bool HasPendingBeltNotification { get; set; }
    public bool HasUnreviewableProjectNotification { get; set; }
    public bool GithubLogin { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public Level Level { get; set; }

    public List<AppUserActivity> UserActivity { get; set; }
    public List<DashboardProject>? DashboardProjects { get; set; }
}

public enum Level
{
    White = 1,
    Green,
    [Display(Name = "Olive Green")]
    OliveGreen,
    Yellow,
    Orange,
    Red,
    Purple,
    Brown,
    Grey,
    Blue,
    Black
}


