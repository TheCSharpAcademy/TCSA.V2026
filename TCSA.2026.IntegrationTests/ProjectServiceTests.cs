using Microsoft.EntityFrameworkCore;
using NetCord.Gateway.JsonModels;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Services;

namespace TCSA._2026.IntegrationTests;

[TestFixture]
public class ProjectServiceTests
{
    private IDbContextFactory<ApplicationDbContext> _factory;
    private ApplicationDbContext _context;
    private ProjectService _service;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb") // This requires the Microsoft.EntityFrameworkCore.InMemory package
            .Options;

        _context = new ApplicationDbContext(options);
        _factory = new TestDbContextFactory(_context);
        _service = new ProjectService(_factory);

        _context.Database.EnsureCreated();
        _context.AspNetUsers.Add(new ApplicationUser
        {
            Id = "user1",
            UserName = "testuser",
            Email = ""
        });
    }

    [TearDown]
    public void TearDown()
    {
        _context.Database.EnsureDeleted(); // Clears the in-memory database
        _context.Dispose(); // Releases resources
    }

    [Test]
    public async Task DashboardProjectsShouldHaveNoDupes()
    {
        await _service.PostArticle(12, "user1", "fakeUrl", false);
        await _service.PostArticle(12, "user1", "fakeUrl", false);

        _context.SaveChanges();

        var list = _context.DashboardProjects.ToList();
    }
}

public class TestDbContextFactory : IDbContextFactory<ApplicationDbContext>
{
    private readonly ApplicationDbContext _context;

    public TestDbContextFactory(ApplicationDbContext context)
    {
        _context = context;
    }

    public ApplicationDbContext CreateDbContext()
    {
        return _context;
    }
}
//Install - Package Microsoft.EntityFrameworkCore.InMemory
