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
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
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
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 2, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 2, 0, 0, 0, DateTimeKind.Utc)
                    ),
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
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 3, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 3, 0, 0, 0, DateTimeKind.Utc)
                    ),
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
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
            },
            UserActivity = new List<AppUserActivity>
            {
                new AppUserActivity
                {
                    ProjectId = 5,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 6,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 2, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 7,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 3, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 8,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
            },
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
            Level = Level.Green,
        };
        user2.PasswordHash = hasher.HashPassword(user2, "Password124!");

        var user3 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user3@example.com",
            NormalizedUserName = "user3@example.com",
            Email = "user3@example.com",
            NormalizedEmail = "user3@example.com",
            FirstName = "Jane",
            LastName = "Doe",
            Country = "AUS",
            ExperiencePoints = 1000,
            ReviewExperiencePoints = 500,
            ReviewedProjects = 9,
            EmailConfirmed = true,
            GithubLogin = false,
            Level = Level.Yellow,

            UserActivity = new List<AppUserActivity>
            {
                new AppUserActivity
                {
                    ProjectId = 9,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 10,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 2, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 11,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 3, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 12,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 13,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
            },

            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 9,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 10,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 11,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 12,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = false,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = true,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 10, 15, 0, 0, DateTimeKind.Utc)
                    ),
                },
                new DashboardProject
                {
                    ProjectId = 13,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = false,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = true,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 12, 0, 1, 0, DateTimeKind.Utc)
                    ),
                },
                new DashboardProject
                {
                    ProjectId = 14,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 15,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 16,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 17,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
            },
        };
        user3.PasswordHash = hasher.HashPassword(user3, "Password123!");

        var user4 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user4@example.com",
            NormalizedUserName = "user4@example.com",
            Email = "user4@example.com",
            NormalizedEmail = "user4@example.com",
            FirstName = "Hulk",
            LastName = "Hogan",
            Country = "AUS",
            ExperiencePoints = 1000,
            ReviewExperiencePoints = 500,
            ReviewedProjects = 3,
            EmailConfirmed = true,
            GithubLogin = false,
            Level = Level.OliveGreen,

            UserActivity = new List<AppUserActivity>
            {
                new AppUserActivity
                {
                    ProjectId = 14,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 15,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 2, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 16,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 3, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 17,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
                new AppUserActivity
                {
                    ProjectId = 18,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ArticleRead,
                },
            },

            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 18,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 19,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 20,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 21,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 22,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 23,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 24,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 25,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 26,
                    GithubUrl = string.Empty,
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
                new DashboardProject
                {
                    ProjectId = 27,
                    GithubUrl = string.Empty,
                    IsCompleted = false,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = true,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                    ),
                    DateRequestedChange = DateTimeOffset.MinValue,
                },
            },
        };
        user4.PasswordHash = hasher.HashPassword(user4, "Password123!");

        var user5 = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "user5@example.com",
            NormalizedUserName = "user5@example.com",
            Email = "user5@example.com",
            NormalizedEmail = "user5@example.com",
            FirstName = "Walter",
            LastName = "White",
            Country = "Germany",
            ExperiencePoints = 723,
            ReviewExperiencePoints = 500,
            ReviewedProjects = 0,
            EmailConfirmed = true,
            GithubLogin = false,
            Level = Level.Green,

            UserActivity = new List<AppUserActivity>
            {
                new AppUserActivity
                {
                    ProjectId = 19,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ProjectCompleted,
                },
                new AppUserActivity
                {
                    ProjectId = 20,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ProjectCompleted,
                },
                new AppUserActivity
                {
                    ProjectId = 21,
                    ChallengeId = 0,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 1, 4, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    ActivityType = ActivityType.ProjectSubmitted,
                },
            },

            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 28,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 10, 15, 0, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 8, 10, 16, 0, 0, DateTimeKind.Utc)
                    ),
                },
                new DashboardProject
                {
                    ProjectId = 29,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 12, 0, 1, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 8, 10, 15, 0, 0, DateTimeKind.Utc)
                    ),
                },
                new DashboardProject
                {
                    ProjectId = 30,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = true,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = false,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 13, 7, 15, 0, DateTimeKind.Utc)
                    ),
                    DateCompleted = new DateTimeOffset(
                        new DateTime(2025, 8, 13, 15, 02, 0, DateTimeKind.Utc)
                    ),
                },
                new DashboardProject
                {
                    ProjectId = 31,
                    GithubUrl =
                        "https://github.com/TheCSharpAcademy/CodeReviews.Console.ShiftsLogger/pull/106",
                    IsCompleted = false,
                    IsArchived = false,
                    IsPendingNotification = false,
                    IsPendingReview = true,
                    DateSubmitted = new DateTimeOffset(
                        new DateTime(2025, 8, 12, 0, 1, 0, DateTimeKind.Utc)
                    ),
                },
            },
        };
        user5.PasswordHash = hasher.HashPassword(user5, "Password123!");

        context.Users.AddRange(user1, user2, user3, user4, user5);
        context.SaveChanges();
    }
}
