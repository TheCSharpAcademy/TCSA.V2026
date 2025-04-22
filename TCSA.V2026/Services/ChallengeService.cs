using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.Services;

public interface IChallengeService
{
    Task<List<Challenge>> GetChallenges(Level level);
}

public class ChallengeService : IChallengeService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public ChallengeService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<List<Challenge>> GetChallenges(Level level)
    {
        using (var context = _factory.CreateDbContext())
        {
            var currentUtcDate = DateTime.UtcNow;
            return await context.Challenges
                .Where(c => c.ReleaseDate <= currentUtcDate && c.Level <= level + 1)
                .OrderByDescending(c => c.ReleaseDate)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
