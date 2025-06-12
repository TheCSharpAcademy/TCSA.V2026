using Microsoft.AspNetCore.Components;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class AdminUserDetailDisplay
{
    public int LoadTime { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public string UserId { get; set; }
    public string DisplayName { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string GithubUsername { get; set; }
    public string DiscordAlias { get; set; }
    public string Country { get; set; }
    public string Level { get; set; }
    public string ExpectedLevel { get; set; }
    public string EmailConfirmed { get; set; }
    public int ProjectsReviewed { get; set; }
    public int IssuesCompleted { get; set; }
    public int ExperiencePoints { get; set; }
    public int ExpectedPoints { get; set; }
}

