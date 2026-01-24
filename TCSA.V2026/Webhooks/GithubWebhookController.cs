using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Services;

namespace TCSA.V2026.Webhooks;

[ApiController]
[Route("api/github")]
public class GithubWebhookController(IGithubService GithubService) : Controller
{
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
}