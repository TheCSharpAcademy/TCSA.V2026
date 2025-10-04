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
        seedContext.AspNetUsers.Add(new ApplicationUser
        {
            Id = "user1",
            UserName = "testuser",
            Email = "test@test.com",
            Country = "Testland",
            FirstName = "Test",
            LastName = "User",

        });

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