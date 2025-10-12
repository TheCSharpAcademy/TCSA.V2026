using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Services;
using TCSA.V2026.Webhooks;

namespace TCSA.V2026.Helpers;

public static class GithubHelper
{
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

    public static int GetProjectId(long repositoryId)
    {
        var projectId = 0;
        if (!Enum.IsDefined(typeof(GithubRepository), repositoryId))
        {
            return 0;
        }

        var repo = (GithubRepository) repositoryId;
        if (!RepoToArticleMap.TryGetValue(repo, out projectId))
        {
            return 0;
        }

        return projectId;
    }
}
