using TCSA.V2026.Data.Models;
using TCSA.V2026.Services;

namespace TCSA.V2026.IntegrationTests;

public class PeerReviewTests : IntegrationTestsBase
{

    private PeerReviewService _service;

    [SetUp]
    public void Setup()
    {
        BaseSetup();
        _service = new PeerReviewService(DbContextFactory);
    }

    [TearDown]
    public void TearDown()
    {
        BaseTearDown();
    }

    [Test]
    public async Task GetProjectsForPeerReview_MathGameNotRetrieved()
    {
        var codeReviewsUrl = "https://github.com/TheCSharpAcademy/CodeReviews";

        using (var seedContext = DbContextFactory.CreateDbContext())
        {
            seedContext.DashboardProjects.AddRange(
                new DashboardProject
                {
                    Id = 1,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.Calculator, // 11
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/Calculator",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-3)
                },
                new DashboardProject
                {
                    Id = 2,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.HabitLogger, // 12
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/HabitLogger",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-2)
                },
                new DashboardProject
                {
                    Id = 3,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.MathGame, // 53 - not in beginnerProjects
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/MathGame",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                },
                new DashboardProject
                {
                    Id = 4,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.PhoneBook, 
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/PhoneBook",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                }
            );

            await seedContext.SaveChangesAsync();
        }

        var projects = await _service.GetProjectsForPeerReview("user2");
        var count = projects.Count;
        Assert.That(count, Is.EqualTo(2));
    }

    [Test]
    public async Task GetProjectsForPeerReview_OrangeBeltCanSeeIntermediateProjects()
    {
        var codeReviewsUrl = "https://github.com/TheCSharpAcademy/CodeReviews";

        using (var seedContext = DbContextFactory.CreateDbContext())
        {
            seedContext.DashboardProjects.AddRange(
                new DashboardProject
                {
                    Id = 1,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.Calculator, // 11
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/Calculator",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-3)
                },
                new DashboardProject
                {
                    Id = 2,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.HabitLogger, // 12
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/HabitLogger",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-2)
                },
                new DashboardProject
                {
                    Id = 3,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.MathGame, // 53 - not in beginnerProjects
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/MathGame",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                },
                new DashboardProject
                {
                    Id = 4,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.PhoneBook,
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/PhoneBook",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                },
                new DashboardProject
                {
                    Id = 5,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.UnitTesting,
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/UnitTesting",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                }
            );

            await seedContext.SaveChangesAsync();
        }

        var projects = await _service.GetProjectsForPeerReview("orangeuser");
        var count = projects.Count;
        Assert.That(count, Is.EqualTo(3));
    }

    [Test]
    public async Task GetProjectsForPeerReview_PurpleBeltCanSeeAdvancedProjects()
    {
        var codeReviewsUrl = "https://github.com/TheCSharpAcademy/CodeReviews";

        using (var seedContext = DbContextFactory.CreateDbContext())
        {
            seedContext.DashboardProjects.AddRange(
                new DashboardProject
                {
                    Id = 1,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.Calculator, // 11
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/Calculator",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-3)
                },
                new DashboardProject
                {
                    Id = 2,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.HabitLogger, // 12
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/HabitLogger",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-2)
                },
                new DashboardProject
                {
                    Id = 3,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.MathGame, // 53 - not in beginnerProjects
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/MathGame",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                },
                new DashboardProject
                {
                    Id = 4,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.PhoneBook,
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/PhoneBook",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                },
                new DashboardProject
                {
                    Id = 5,
                    AppUserId = "user1",
                    ProjectId = (int)ArticleName.UnitTesting,
                    IsPendingReview = true,
                    GithubUrl = $"{codeReviewsUrl}/UnitTesting",
                    DateSubmitted = DateTimeOffset.Now.AddDays(-1)
                }
            );

            await seedContext.SaveChangesAsync();
        }

        var projects = await _service.GetProjectsForPeerReview("purpleuser");
        var count = projects.Count;
        Assert.That(count, Is.EqualTo(4));
    }
    //[Test]
    //public async Task GetProjectsForPeerReview_GivenUserCompletedMVC_canSeeMVCProjects()
    //{
    //    var codeReviewsUrl = "https://github.com/TheCSharpAcademy/CodeReviews";

    //    using (var seedContext = DbContextFactory.CreateDbContext())
    //    {
    //        seedContext.DashboardProjects.AddRange(
    //            new DashboardProject
    //            {
    //                Id = 1,
    //                AppUserId = "user1",
    //                ProjectId = (int)ArticleName.Calculator, // 11
    //                IsPendingReview = true,
    //                GithubUrl = $"{codeReviewsUrl}/Calculator",
    //                DateSubmitted = DateTimeOffset.Now.AddDays(-3)
    //            },
    //            new DashboardProject
    //            {
    //                Id = 2,
    //                AppUserId = "user1",
    //                ProjectId = (int)ArticleName.HabitLogger, // 12
    //                IsPendingReview = true,
    //                GithubUrl = $"{codeReviewsUrl}/HabitLogger",
    //                DateSubmitted = DateTimeOffset.Now.AddDays(-2)
    //            },
    //            new DashboardProject
    //            {
    //                Id = 3,
    //                AppUserId = "user1",
    //                ProjectId = (int)ArticleName.MathGame, // 53 - not in beginnerProjects
    //                IsPendingReview = true,
    //                GithubUrl = $"{codeReviewsUrl}/MathGame",
    //                DateSubmitted = DateTimeOffset.Now.AddDays(-1)
    //            },
    //            new DashboardProject
    //            {
    //                Id = 4,
    //                AppUserId = "user1",
    //                ProjectId = (int)ArticleName.PhoneBook,
    //                IsPendingReview = true,
    //                GithubUrl = $"{codeReviewsUrl}/PhoneBook",
    //                DateSubmitted = DateTimeOffset.Now.AddDays(-1)
    //            },
    //            new DashboardProject
    //            {
    //                Id = 5,
    //                AppUserId = "user1",
    //                ProjectId = (int)ArticleName.UnitTesting,
    //                IsPendingReview = true,
    //                GithubUrl = $"{codeReviewsUrl}/UnitTesting",
    //                DateSubmitted = DateTimeOffset.Now.AddDays(-1)
    //            },
    //            new DashboardProject
    //             {
    //                 Id = 6,
    //                 AppUserId = "user1",
    //                 ProjectId = (int)ArticleName.WaterLogger,
    //                 IsPendingReview = true,
    //                 GithubUrl = $"{codeReviewsUrl}/WaterLogger",
    //                 DateSubmitted = DateTimeOffset.Now.AddDays(-1)
    //             }
    //        );

    //        await seedContext.SaveChangesAsync();
    //    }

    //    var projects = await _service.GetProjectsForPeerReview("purpleuser");
    //    var count = projects.Count;
    //    Assert.That(count, Is.EqualTo(5));
    //}
}