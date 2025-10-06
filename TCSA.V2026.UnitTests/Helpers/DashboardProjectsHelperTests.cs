using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

public class DashboardProjectsHelperTests
{
    public static IEnumerable<Article> Articles;
    public static IEnumerable<Project> Projects;

    [SetUp]
    public void SetUp()
    {
        var mockConfig = new Mock<IConfiguration>();
        mockConfig.Setup(c => c["LinkProvider:DiscordLink"]).Returns("https://discord.gg/test");

        ServiceProviderAccessor.ServiceProvider = new ServiceCollection()
            .AddSingleton(mockConfig.Object)
            .BuildServiceProvider();
    }

    [Test]
    public void ProjectsNotCompletedShouldReturnFalse()
    {
        List<int> completedProjects = new List<int> {
            (int)ArticleName.StartHere
        };

        var result =  DashboardProjectsHelpers.CheckIfAreaIsCompleted(DashboardProjectsHelpers.Projects, DashboardProjectsHelpers.Articles, completedProjects, Area.Blazor, null);

        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void ProjectsCompletedShouldReturnTrue()
    {
        List<int> completedProjects = new List<int> {
            (int)ArticleName.StartHere,
            (int)ArticleName.WardrobeInventory,
            (int)ArticleName.MemoryGame,
            (int)ArticleName.FoodJournal,
            (int)ArticleName.SportsStatistics,
        };

        var result = DashboardProjectsHelpers.CheckIfAreaIsCompleted(DashboardProjectsHelpers.Projects, DashboardProjectsHelpers.Articles, completedProjects, Area.Blazor, null);

        Assert.That(result, Is.EqualTo(true));
    }
}
