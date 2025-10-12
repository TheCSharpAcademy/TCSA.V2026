using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data;
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