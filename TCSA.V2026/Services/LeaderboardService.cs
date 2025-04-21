using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Services;

public interface ILeaderboardService
{
    Task<int> GetUserRanking(string userId);
    Task<List<UserLeaderboardDisplay>> GetUsersForLeaderboard(int pageNumber);
    Task<List<UserReviewLeaderboardDisplay>> GetUserForReviewLeaderboard();
}
public class LeaderboardService : ILeaderboardService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public LeaderboardService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<UserReviewLeaderboardDisplay>> GetUserForReviewLeaderboard()
    {
        var users = new List<ApplicationUser>();
        var result = new List<UserReviewLeaderboardDisplay>();
        var index = 1;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = await context.Users
                .Include(x => x.CodeReviewProjects)
                .Where(x => x.ReviewExperiencePoints > 0)
                .ToListAsync();

                foreach (ApplicationUser user in users)
                {
                    var userForLeaderboard = new UserReviewLeaderboardDisplay
                    {
                        Id = user.Id,
                        Country = user.Country,
                        DisplayName = user.DisplayName,
                        TotalXp = user.ReviewExperiencePoints,
                        ReviewsNumber = user.CodeReviewProjects.Count()
                    };

                    result.Add(userForLeaderboard);
                }

                result = result
                    .OrderByDescending(x => x.TotalXp)
                    .Take(50)
                    .ToList();

                foreach (var user in result)
                {
                    user.Ranking = index;
                    index++;
                }
                return result;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public async Task<List<UserLeaderboardDisplay>> GetUsersForLeaderboard(int pageNumber)
    {
        var users = new List<ApplicationUser>();
        var result = new List<UserLeaderboardDisplay>();
        var index = pageNumber == 0 ? 0 : pageNumber * 50;

        try
        {
            using (var context = _factory.CreateDbContext())
            {
                users = await context.Users
                .Where(x => x.ExperiencePoints > 0)
                .OrderByDescending(x => x.ExperiencePoints)
                .ThenBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Skip(pageNumber * 50)
                .Take(50)
                .ToListAsync();
            }
        }
        catch (Exception ex)
        {
            return null;
        }

        foreach (var user in users)
        {
            index++;
            var userForLeaderboard = new UserLeaderboardDisplay
            {
                Id = user.Id,
                Country = user.Country,
                Level = user.Level,
                DisplayName = user.DisplayName,
                ExperiencePoints = user.ExperiencePoints,
                Ranking = index
            };

            userForLeaderboard.GithubUsername = user.GithubUsername ?? string.Empty;
            userForLeaderboard.LinkedInUrl = user.LinkedInUrl ?? string.Empty;

            result.Add(userForLeaderboard);
        }

        return result;
    }

    public async Task<int> GetUserRanking(string userId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var rankingParameter = new SqlParameter("ranking", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

                var parameters = new[]
                {
                    new SqlParameter("userId", userId),
                    rankingParameter
                };

                context.Database.ExecuteSqlRaw("EXEC GetRanking @userId, @ranking OUT", parameters);

                if (rankingParameter.Value != DBNull.Value)
                {
                    return (int)rankingParameter.Value;
                }

                return -1;
            }
        }
        catch (Exception ex)
        {
            return 0;
        }
    }
}
