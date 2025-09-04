using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class PointsHelperTests
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
    public void ArticlesReadShouldReturnCorrectPoints()
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 5,
                    IsCompleted = true,
                }
            }
        };

        int points = PointsHelper.GetExpectedPoints(user);   

        Assert.That(points.Equals(5));
    }

    [Test]
    public void ArticlesAndProjectsShouldReturnCorrectPoints()
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 5,
                    IsCompleted = true,
                },
                new DashboardProject
                {
                    ProjectId = 12,
                    IsCompleted = true,
                }
            }
        };

        int points = PointsHelper.GetExpectedPoints(user);

        Assert.That(points.Equals(15));
    }

    [Test]  
    public void ArticlesAndProjectsAndReviewsShouldReturnCorrectPoints()
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 5,
                    IsCompleted = true,
                },
                new DashboardProject
                {
                    ProjectId = 12,
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
        };

        int points = PointsHelper.GetExpectedPoints(user);

        Assert.That(points.Equals(35));
    }

    [Test]
    public void ArticlesAndProjectsAndReviewsAndChallengesShouldReturnCorrectPoints()
    {
        var user = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            DashboardProjects = new List<DashboardProject>
            {
                new DashboardProject
                {
                    ProjectId = 5,
                    IsCompleted = true,
                },
                new DashboardProject
                {
                    ProjectId = 12,
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
            }
        };

        int points = PointsHelper.GetExpectedPoints(user);

        Assert.That(points.Equals(36));
    }

    [Test]
    public void ArticlesAndProjectsAndReviewsAndChallengesAndCoursesShouldReturnCorrectPoints()
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
            }
        };

        int points = PointsHelper.GetExpectedPoints(user);

        Assert.That(points.Equals(37));
    }

    [Test]
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

        int points = PointsHelper.GetExpectedPoints(user);

        Assert.That(points.Equals(57));
    }
}
