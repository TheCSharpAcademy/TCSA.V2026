using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TCSA.V2026.Data;

namespace TCSA.V2026.Services;

public interface ILeaderboardService
{
    Task<int> GetUserRanking(string userId);
}
public class LeaderboardService : ILeaderboardService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public LeaderboardService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
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
