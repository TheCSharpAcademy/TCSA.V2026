using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;
using TCSA.V2026.Data.Models;
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
    //public async Task<IActionResult> Receive([FromBody] JsonElement payload)
    //{
    //    var json = JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = true });
    //    Console.WriteLine(json); // Or use ILogger
    //    return Ok();
    //}

    public async Task<IActionResult> Receive([FromBody] GitHubWebhookDto payload)
    {
        int projectId = 0;
        if (payload.Review?.State != "approved") { return Ok(); }

        if (Enum.IsDefined(typeof(GithubRepository), payload.Repository.Id))
        {
            var repo = (GithubRepository)payload.Repository.Id;
            Console.WriteLine($"Matched repository: {repo}");

            if (RepoToArticleMap.TryGetValue(repo, out projectId))
            {
                Console.WriteLine($"Mapped to article: {projectId}");
            }
            else
            {
                Console.WriteLine($"No article mapping found for repository: {repo}");
            }
        }
        else
        {
            Console.WriteLine($"Unknown repository ID: {payload.Repository.Id}");
        }

        await GithubService.MarkAsCompleted(projectId, payload.PullRequest.Number);

        return Ok();
    }

    private static readonly Dictionary<GithubRepository, int> RepoToArticleMap = new()
    {
        { GithubRepository.MathGame, (int)ArticleName.MathGame },
        { GithubRepository.Calculator, (int)ArticleName.Calculator },
        { GithubRepository.HabitLogger, (int)ArticleName.HabitLogger },
        { GithubRepository.CodingTracker, (int)ArticleName.CodingTracker },
        { GithubRepository.Flashcards, (int)ArticleName.Flashcards },
        { GithubRepository.Drinks, (int)ArticleName.Drinks },
        { GithubRepository.PhoneBook, (int)ArticleName.PhoneBook },
        { GithubRepository.ShiftsLogger, (int)ArticleName.ShiftsLogger },
        { GithubRepository.Ecommerce, (int)ArticleName.Ecommerce },
        { GithubRepository.SportsResults, (int)ArticleName.SportsResults },
        { GithubRepository.ExcelReader, (int)ArticleName.ExcelReader },
        { GithubRepository.UnitTesting, (int)ArticleName.UnitTesting }
    };


}

public enum GithubRepository : long
{
    MathGame = 587597495,
    Calculator = 573911382,
    HabitLogger = 573675655,
    CodingTracker = 573911543,
    Flashcards = 573911617,
    Drinks = 573911726,
    PhoneBook = 573911920,
    ShiftsLogger = 573912212,
    Ecommerce = 573912286,
    SportsResults = 675864949,
    ExcelReader = 573912431,
    UnitTesting = 573912512
}

public class GitHubWebhookDto
{
    public string Action { get; set; }

    public Repository Repository { get; set; }

    public Review Review { get; set; }

    [JsonPropertyName("pull_request")]
    public PullRequest PullRequest { get; set; }
}

public class PullRequest
{
    public int Number { get; set; }
}

public class Repository
{
    public long Id { get; set; }
}

public class Review
{
    public string State { get; set; }
}