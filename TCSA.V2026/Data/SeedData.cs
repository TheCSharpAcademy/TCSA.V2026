using Microsoft.AspNetCore.Identity;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data;

public static class SeedData
{
    public static void Seed(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        SeedUsers(context);
    }

    private static void SeedUsers(ApplicationDbContext context)
    {
        var hasher = new PasswordHasher<ApplicationUser>();

        var user1 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user1@example.com",
            NormalizedUserName = "user1@example.com",
            Email = "user1@example.com",
            NormalizedEmail = "user1@example.com",
            FirstName = "John",
            LastName = "Doe",
            Country = "USA",
            ExperiencePoints = 1000,
            ReviewExperiencePoints = 500,
            ReviewedProjects = 5,
            EmailConfirmed = true,
            GithubLogin = false,
            Level = Level.Orange,
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 5,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)),
                    DateCompleted = new DateTimeOffset(new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 6,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 2, 0, 0, 0, DateTimeKind.Utc)),
                    DateCompleted = new DateTimeOffset(new DateTime(2025, 1, 2, 0, 0, 0, DateTimeKind.Utc)),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 7,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 3, 0, 0, 0, DateTimeKind.Utc)),
                    DateCompleted = new DateTimeOffset(new DateTime(2025, 1, 3, 0, 0, 0, DateTimeKind.Utc)),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 8,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 4, 0, 0, 0, DateTimeKind.Utc)),
                    DateCompleted = new DateTimeOffset(new DateTime(2025, 1, 4, 0, 0, 0, DateTimeKind.Utc)),
                    DateRequestedChange = DateTimeOffset.MinValue,
                }
            },
            UserActivity = new List<AppUserActivity>
            {
                new AppUserActivity
                {
                    ProjectId = 5,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 1, 0, 1, 0, DateTimeKind.Utc)),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 6,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 2, 0, 1, 0, DateTimeKind.Utc)),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 7,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 3, 0, 1, 0, DateTimeKind.Utc)),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 8,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)),
                    ActivityType = ActivityType.ArticleRead,
                }
            }
        };
        user1.PasswordHash = hasher.HashPassword(user1, "Password123!");

        var user2 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user2@example.com",
            NormalizedUserName = "user2@example.com",
            Email = "user2@example.com",
            NormalizedEmail = "user2@example.com",
            FirstName = "Jane",
            LastName = "Smith",
            Country = "Canada",
            ExperiencePoints = 1500,
            ReviewExperiencePoints = 700,
            ReviewedProjects = 8,
            EmailConfirmed = true,
            GithubLogin = false,
            Level = Level.Green
        };
        user2.PasswordHash = hasher.HashPassword(user2, "Password124!");

        context.Users.AddRange(user1, user2);
        context.SaveChanges();
    }
}
