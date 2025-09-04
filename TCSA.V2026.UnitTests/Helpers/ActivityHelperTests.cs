using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class ActivityHelperTests
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

    public void ArticlesAndProjectsAndReviewsAndChallengesAndCoursesAndIssuesShouldReturnCorrectPoints()
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = (int) ArticleName.StartHere,
                    IsCompleted = true,
                },
                new DashboardProject
                {
                    ProjectId = (int) ArticleName.HabitLogger,
                    IsCompleted = true,
                },
                new DashboardProject
                {
                    ProjectId = (int) ArticleName.CoursesOopIntro,
                    IsCompleted = true,
                }
            },
            CodeReviewProjects = new List<UserReview>
            {
                new UserReview
                {
                    DashboardProject = new DashboardProject
                    {
                        ProjectId = 13,
                        IsCompleted = true,
                    }
                },
                new UserReview
                {
                    DashboardProject = new DashboardProject
                    {
                        ProjectId = 11,
                        IsCompleted = false,
                        IsArchived = true,
                    }
                }
            },
            UserChallenges = new List<UserChallenge> {
                new UserChallenge
                {
                    Challenge = new Challenge { ExperiencePoints = 1 }
                }
            },
            Issues = new List<CommunityIssue>
            {
                new CommunityIssue
                {
                    IsClosed = true,
                    ExperiencePoints = 20
                }
            }
        };

        var display = ActivityHelper.GetActivityDisplay(user);

        Assert.That(points.Equals(57));
    }
}
