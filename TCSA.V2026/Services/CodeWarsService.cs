using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Helpers.ProjectsSubHelpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Models.Responses;

namespace TCSA.V2026.Services;

public interface ICodewarsService
{
    Task<int> MarkCodeWarsAsCompleted(int projectId, string userId, int currentPoints);
    Task<BaseResponse> Sync(string? username, int challengeId, string externalId, string userId);
}

public class CodewarsService: ICodewarsService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly HttpClient _httpClient;

    public CodewarsService(IDbContextFactory<ApplicationDbContext> factory, IHttpClientFactory httpClientFactory)
    {
        _factory = factory;
        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task<BaseResponse> Sync(string? username, int challengeId, string externalId, string userId)
    {
        var result = new BaseResponse();

        if (username == null)
        {
            result.Status = ResponseStatus.Fail;
            result.Message = "You haven't integrated your Codewars account yet. Go to the dashboard and click on 'Codewars Integration'";
            return result;
        }

        string apiUrl = $"https://www.codewars.com/api/v1/users/{username}/code-challenges/completed?";

        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            result.Status = ResponseStatus.Fail;
            result.Message = "Username not found. Go to the dashboard and click on 'Codewars Integration' to update your username.";
            return result;
        }

        string jsonResponse = await response.Content.ReadAsStringAsync();
        CodeWarsApiResponse apiResponse = JsonSerializer.Deserialize<CodeWarsApiResponse>(jsonResponse);

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var project = context.UserChallenges.Add(new UserChallenge
                {
                    UserId = userId,
                    ChallengeId = challengeId,
                    CompletedAt = DateTime.UtcNow
                });
                await context.SaveChangesAsync();
            }

            return result;
        }
        catch (Exception ex)
        {
            result.Message = ex.Message;
            result.Status = ResponseStatus.Fail;
            return result;
        }
    }

    public async Task<int> MarkCodeWarsAsCompleted(int projectId, string userId, int currentPoints)
    {
        var project = SqlProjectsHelper.GetProjects().FirstOrDefault(x => x.Id == projectId);

        using (var context = _factory.CreateDbContext())
        {
            var dashboardProject = new DashboardProject
            {
                ProjectId = projectId,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                IsCompleted = true,
                IsPendingNotification = true,
                IsPendingReview = false,
                DateRequestedChange = DateTime.UtcNow,
                GithubUrl = "Not applicable"
            };

            context.DashboardProjects
                .Add(dashboardProject);

            context.UserActivity.Add(new AppUserActivity
            {
                ProjectId = projectId,
                AppUserId = userId,
                DateSubmitted = DateTime.UtcNow,
                ActivityType = ActivityType.ProjectCompleted
            });

            context.Users
                .Where(x => x.Id == userId)
                .ExecuteUpdate(y => y.SetProperty(u => u.ExperiencePoints, project.ExperiencePoints + currentPoints));

            return await context.SaveChangesAsync();
        }
    }
}