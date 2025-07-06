using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class BeltTests
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
    public void GreenNotCompleteShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int>(), 0, 0);
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void GreenCompleteShouldReturnGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, //articles
            53, 75 // math, fcc
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void HabitCompletedShouldStillReturnGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
             5, 6, 7, 8, //articles
             11, //habit
             53, 75 // math, fcc
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void CodingCompletedShouldStillReturnGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8, //articles
            11, 12, // habit, coding
            53, 75 // math, fcc
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void OliveGreenCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8,
            11, 12, 13, // calculator, habit, coding
            53, 75 
        }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void FlashcardsCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 14, // calculator, habit, coding, flashcards
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void DrinksCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void PhonebookCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void ShiftsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExerciseCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void SportsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExcelCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void TestingCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void PortfolioCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void ResumeCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 0, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 1, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 1, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndTwoReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 1, 2);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void TwoIssuesAndFourReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 53, 75 }, 2, 3);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughIssuesShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 53, 75 }, 1, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void ReactCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 35, 36, 37, 38, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AngularCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 31, 32, 33, 34, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void BlazorCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 39, 40, 41, 42, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void MauiCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 43, 44, 45, 46, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void JumpingAroundShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 31, 32, 33, 35, 36, 37, 43, 39, 40, 41, 44, 45, 53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void FCCMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 31, 32, 33, 35, 36, 37, 43, 39, 40, 41, 44, 45, 53 }, 2, 4);
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void MathMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 31, 32, 33, 35, 36, 37, 43, 39, 40, 41, 44, 45, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void SQLCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 43, 44, 45, 46, 53, 75, 76, 77, 78 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void NoFlagshipShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 43, 44, 45, 46, 53, 75, 76, 77, 78 }, 5, 7);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void FlagshipShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 5, 6, 7, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 43, 44, 45, 46, 53, 75, 76, 77, 78, 139}, 7, 12);
        Assert.That(result, Is.EqualTo("Brown"));
    }
}

//// public static string GetExpectedBelt(List<int> completedProjects, int issues, int reviews)
//    {
//        var level = Level.White;

//level = GreenRequirements.All(completedProjects.Contains)? Level.Green : level;
//level = (level >= Level.Green && OliveGreenRequirements.All(completedProjects.Contains)) ? Level.OliveGreen : level;
//level = (level >= Level.OliveGreen && YellowRequirements.All(completedProjects.Contains)) ? Level.Yellow : level;
//level = (level >= Level.Yellow && OrangeRequirements.All(completedProjects.Contains)) ? Level.Orange : level;

//        return level.ToString();
//    }