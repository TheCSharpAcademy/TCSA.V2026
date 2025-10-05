using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;
using TaskStatus = TCSA.V2026.Data.DTOs.TaskStatus;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class DashboardProjectsHelpersTests
{
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
    public void GetTaskStatus_ShouldReturnPendingReviewStatus_WhenProjectIsPending()
    {
        // Arrange
        var projectId = 4;
        var completedProjects = new List<int> { 1, 2, 3 };
        var pendingReviewProjects = new List<int> { 4 };

        // Act
        var status = DashboardProjectsHelpers.GetTaskStatus(projectId, completedProjects, pendingReviewProjects);

        // Assert
        Assert.That(status, Is.EqualTo(TaskStatus.PendingReview));
    }

    [Test]
    public void GetTaskStatus_ShouldReturnCompletedStatus_WhenProjectIsCompleted()
    {
        // Arrange
        var projectId = 3;
        var completedProjects = new List<int> { 1, 2, 3 };
        var pendingReviewProjects = new List<int> { 4 };

        // Act
        var status = DashboardProjectsHelpers.GetTaskStatus(projectId, completedProjects, pendingReviewProjects);

        // Assert
        Assert.That(status, Is.EqualTo(TaskStatus.Completed));
    }

    [Test]
    public void GetTaskStatus_ShouldReturnNotCompletedStatus_WhenProjectIsNotCompleted()
    {
        // Arrange
        var projectId = 5;
        var completedProjects = new List<int> { 1, 2, 3 };
        var pendingReviewProjects = new List<int> { 4 };

        // Act
        var status = DashboardProjectsHelpers.GetTaskStatus(projectId, completedProjects, pendingReviewProjects);

        // Assert
        Assert.That(status, Is.EqualTo(TaskStatus.NotCompleted));
    }

    [TestCase(Area.StartHere, (int)ArticleName.StartHere, "start-here")]
    [TestCase(Area.StartHere, (int)ArticleName.GettingHelp, "getting-help")]
    [TestCase(Area.StartHere, (int)ArticleName.SettingUp, "setting-up")]
    [TestCase(Area.StartHere, (int)ArticleName.Foundations, "foundations")]
    [TestCase(Area.StartHere, (int)ArticleName.ImportanceOfConsole, "the-importance-of-console-applictions")]
    public void GetUrl_ShouldReturnArticleUrl_ForStartHereArea(Area area, int taskId, string taskSlug)
    {
        // Act
        var url = DashboardProjectsHelpers.GetUrl(area, taskId, taskSlug);

        // Assert
        Assert.That(url, Is.EqualTo($"article/{taskId}/{taskSlug}"));
    }

    [Test]
    public void GetUrl_ShouldReturnProjectUrl_ForFreecodeCampCertification()
    {
        // Arrange
        var area = Area.StartHere;
        var taskId = (int)ArticleName.FreecodeCamp;
        var taskSlug = "freecodecamp-certification";

        // Act
        var url = DashboardProjectsHelpers.GetUrl(area, taskId, taskSlug);

        // Assert
        Assert.That(url, Is.EqualTo($"project/{taskId}/{taskSlug}"));
    }

    [Test]
    public void GetUrl_ShouldReturnProjectUrl_ForOtherAreas()
    {
        // Arrange
        var area = Area.MVC;
        var taskId = 24;
        var taskSlug = "water-logger";

        // Act
        var url = DashboardProjectsHelpers.GetUrl(area, taskId, taskSlug);

        // Assert
        Assert.That(url, Is.EqualTo($"project/{taskId}/{taskSlug}"));
    }
}