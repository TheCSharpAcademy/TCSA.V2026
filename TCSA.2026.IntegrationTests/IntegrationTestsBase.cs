using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Enums;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.IntegrationTests;

public class IntegrationTestsBase
{
    protected IDbContextFactory<ApplicationDbContext> DbContextFactory;
    protected IServiceProvider ServiceProvider;

    [SetUp]
    public virtual void BaseSetup()
    {
        var mockConfig = new Mock<IConfiguration>();
        mockConfig.Setup(c => c["LinkProvider:DiscordLink"]).Returns("https://discord.gg/test");

        ServiceProvider = new ServiceCollection()
            .AddSingleton(mockConfig.Object)
            .BuildServiceProvider();

        ServiceProviderAccessor.ServiceProvider = ServiceProvider;

        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        DbContextFactory = new TestDbContextFactory(options);

        using var seedContext = DbContextFactory.CreateDbContext();
        seedContext.Database.EnsureCreated();

        var testUsers = new List<ApplicationUser>
        {
            new ApplicationUser
            {
                Id = "user1",
                UserName = "testuser",
                Email = "test@test.com",
                GithubUsername = "TheCSharpAcademy",
                Country = "Testland",
                FirstName = "Test",
                LastName = "User",
                ExperiencePoints = 0,
                DashboardProjects = new List<DashboardProject>()
            },
            new ApplicationUser
            {
                 Id = "user2",
                 UserName = "testuser2",
                 Email = "test2@test.com",
                 GithubUsername = "testGithubUsername2",
                 Country = "Testonia",
                 FirstName = "Testingson",
                 LastName = "Userson",
                 Level = Level.Yellow,
                 ExperiencePoints = 100
            },
            new ApplicationUser
            {
                 Id = "orangeuser",
                 UserName = "testuser3",
                 Email = "test3@test.com",
                 GithubUsername = "testGithubUsername3",
                 Country = "Testistan",
                 FirstName = "Testinik",
                 LastName = "Userpapa",
                 Level = Level.Orange,
                 ExperiencePoints = 100
            },
             new ApplicationUser
            {
                 Id = "purpleuser",
                 UserName = "testuser4",
                 Email = "test4@test.com",
                 GithubUsername = "testGithubUsername4",
                 Country = "PurpleLand",
                 FirstName = "Lila",
                 LastName = "UserLila",
                 Level = Level.Purple,
                 ExperiencePoints = 100,
                 DashboardProjects = new()
                 {
                     new DashboardProject
                     {
                         Id = 11,
                         AppUserId = "purpleuser",
                         ProjectId = (int)ArticleName.WaterLogger, // 11
                         IsCompleted = true,
                         GithubUrl = $"WaterLogger",
                         DateSubmitted = DateTimeOffset.Now.AddDays(-3)
                     },
                     new DashboardProject
                     {
                         Id = 12,
                         AppUserId = "purpleuser",
                         ProjectId = (int)ArticleName.Movies, // 12
                         IsCompleted = true,
                         GithubUrl = $"Movies",
                         DateSubmitted = DateTimeOffset.Now.AddDays(-2)
                     },
                     new DashboardProject
                     {
                         Id = 13,
                         AppUserId = "purpleuser",
                         ProjectId = (int)ArticleName.TodoList, // 53 - not in beginnerProjects
                         IsCompleted = true,
                         GithubUrl = $"TodoList",
                         DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                     },
                     new DashboardProject
                     {
                         Id = 14,
                         AppUserId = "purpleuser",
                         ProjectId = (int)ArticleName.Budget,
                         IsCompleted = true,
                         GithubUrl = $"Budget",
                         DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                     }
                 }
            }
        };

        seedContext.AspNetUsers.AddRange(testUsers);

        seedContext.SaveChanges();
    }

    [TearDown]
    public void BaseTearDown()
    {
        using var context = DbContextFactory.CreateDbContext();
        context.Database.EnsureDeleted();

        if (ServiceProvider is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}

public class TestDbContextFactory : IDbContextFactory<ApplicationDbContext>
{
    private readonly DbContextOptions<ApplicationDbContext> _options;

    public TestDbContextFactory(DbContextOptions<ApplicationDbContext> options)
    {
        _options = options;
    }

    public ApplicationDbContext CreateDbContext()
    {
        return new ApplicationDbContext(_options);
    }
}