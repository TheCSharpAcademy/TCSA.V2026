using TCSA.V2026.Services;

namespace TCSA.V2026.IntegrationTests;

[TestFixture]
public class ProjectServiceTests : IntegrationTestsBase
{
    private ProjectService _service;

    [SetUp]
    public void Setup()
    {
        BaseSetup();
        _service = new ProjectService(DbContextFactory);
    }

    [TearDown]
    public void TearDown()
    {
        BaseTearDown();
    }

    [Test]
    public async Task DashboardProjectsShouldHaveNoDupes()
    {
        await _service.PostArticle(12, "user1", "fakeUrl", false);
        await _service.PostArticle(12, "user1", "fakeUrl", false);

        using var verifyContext = DbContextFactory.CreateDbContext();

        var list = verifyContext.DashboardProjects
        .Where(p => p.ProjectId == 12 && p.AppUserId == "user1")
        .ToList();

        Assert.That(list.Count, Is.EqualTo(1));
    }
}
