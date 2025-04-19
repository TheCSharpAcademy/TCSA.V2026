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
            Id = "1",
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
            Level = Level.Orange
        };
        user1.PasswordHash = hasher.HashPassword(user1, "Password123!");

        var user2 = new ApplicationUser
        {
            Id = "2",
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
