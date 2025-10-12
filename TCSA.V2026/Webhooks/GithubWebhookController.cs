using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using TCSA.V2026.Services;

namespace TCSA.V2026.Webhooks;

[ApiController]
[Route("api/github")]
public class GithubWebhookController : Controller
{
    private IGithubService GithubService
    {
        get;
    }

    public GithubWebhookController(IGithubService githubService)
    {
        GithubService = githubService;
    }

    [HttpPost]
    public async Task<IActionResult> Receive([FromBody] JsonElement payload)
    {
        var json = JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = true });

        var eventType = Request.Headers["X-GitHub-Event"].ToString();

        switch (eventType)
        {
            case "pull_request":
                var prDto = JsonSerializer.Deserialize<PullRequestDto>(
                    payload.GetRawText(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );

                await GithubService.ProcessPullRequest(prDto);
                break;

            case "pull_request_review":
                var reviewDto = JsonSerializer.Deserialize<PullRequestReviewDto>(
                    payload.GetRawText(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                );
                await GithubService.MarkAsCompleted(reviewDto);
                break;

            default:
                return NoContent();
        }

        return Ok();
    }

    //public async Task<IActionResult> Receive([FromBody] GitHubWebhookDto payload)
    //{
    //    if (payload.Action.Equals("opened"))
    //    {
    //        Console.WriteLine("yay");
    //    }

    //    int projectId = 0;

    //    if (payload.Review?.State != "approved")
    //    {
    //        return NoContent();
    //    }

    //    if (Enum.IsDefined(typeof(GithubRepository), payload.Repository.Id))
    //    {
    //        var repo = (GithubRepository)payload.Repository.Id;

    //        if (!RepoToArticleMap.TryGetValue(repo, out projectId))
    //        {
    //            return NoContent();
    //        }

    //        await GithubService.MarkAsCompleted(projectId, payload.PullRequest.Number);

    //        return Ok();
    //    }

    //    return NoContent();
    //}


}

public class PullRequestDto
{
    public string Action
    {
        get; set;
    }

    public Repository Repository
    {
        get; set;
    }

    [JsonPropertyName("pull_request")]
    public PullRequest PullRequest
    {
        get; set;
    }
}

public class PullRequestReviewDto
{
    public string Action
    {
        get; set;
    }

    public Repository Repository
    {
        get; set;
    }

    public Review Review
    {
        get; set;
    }

    [JsonPropertyName("pull_request")]
    public PullRequest PullRequest
    {
        get; set;
    }
}

public class PullRequest
{
    public int Number
    {
        get; set;
    }
    public User User
    {
        get; set;
    }

    [JsonPropertyName("html_url")]
    public string HtmlUrl
    {
        get; set;
    }
}

public class Repository
{
    public long Id
    {
        get; set;
    }
}

public class User
{
    public string Login
    {
        get; set;
    }
}

public class Review
{
    public string State
    {
        get; set;
    }
}