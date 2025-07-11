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
            11, 12, 13, // calculator, habit, coding
            14, // flashcards
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void DrinksCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, // calculator, habit, coding
            14, 15, // flashcards, drinks
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void PhonebookCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, // flashcards, drinks, phonebook
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void ShiftsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, // flashcards, drinks, phonebook, shifts
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExerciseCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, // exercise
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void SportsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, // exercise, sports 
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExcelCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, // exercise, sports, excel
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void TestingCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, // exercise, sports, excel, unit tests
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void PortfolioCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, // portfolio
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void ResumeCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, // portfolio, resume
            53, 75 }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            53, 75 }, 0, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            53, 75 }, 1, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            53, 75 }, 1, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndTwoReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            53, 75 }, 1, 2);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void TwoIssuesAndFourReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            24, 25, 26, 27, // aspnetcore
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            24, 25, 26, 27, // aspnetcore
            53, 75 }, 2, 3);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughIssuesShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            24, 25, 26, 27, // aspnetcore
            53, 75 }, 1, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void ReactCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            35, 36, 37, 38, // react
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AngularCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            31, 32, 33, 34,  // angular
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void BlazorCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            39, 40, 41, 42, // blazor
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void MauiCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            43, 44, 45, 46, // maui
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void JumpingAroundShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            24, 25, 26, // aspnetcore
            31, 32, 33, // angular
            35, 36, 37, // react
            43, 44, 45, // maui
            39, 40, 41, // blazor
            53, 75 }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void FCCMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            24, 25, 26, 
            31, 32, 33, 
            35, 36, 37, 
            43, 44, 45, 46, // maui
            39, 40, 
            53 }, 2, 4); // missing FCC
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void MathMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            24, 25, 26,
            31, 32, 33,
            35, 36, 37,
            43, 44, 45, 46, // maui
            39, 40,
            53 }, 2, 4); // missing math
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void AuthCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74 // Auth
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AuthCompleteShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74 // Auth
        }, 5, 7);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void SQLCompleteShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            43, 44, 45, 46, 
            53, 75,
            28, 72, 74,
            76, 77, 78 // SQL
        }, 5, 7);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void NoFlagshipShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21,
            22, 23, 
            43, 44, 45, 46, 
            53, 75,
            28, 72, 74,
            76, 77, 78 
        }, 7, 12);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void FlagshipShouldReturnGrey()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> { 
            5, 6, 7, 8, 
            11, 12, 13, 
            14, 15, 16, 17, 
            18, 19, 20, 21, 
            22, 23, 
            43, 44, 45, 46, 
            53, 75,
            28, 72, 74,
            76, 77, 78, // SQL
            139 // flagship
        }, 7, 12);
        Assert.That(result, Is.EqualTo("Grey"));
    }

    [Test]
    public void AzureShouldReturnGrey()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74,
            76, 77, 78, // SQL
            47, 48, 49, 50, // Azure
            139 // flagship
        }, 7, 12);
        Assert.That(result, Is.EqualTo("Grey"));
    }

    [Test]
    public void AzureShouldReturnBlue()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74,
            76, 77, 78, // SQL
            47, 48, 49, 50, // Azure
            139 // flagship
        }, 10, 17);
        Assert.That(result, Is.EqualTo("Blue"));
    }

    [Test]
    public void TwoFullStacksShouldReturnBlue()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            24, 25, 26, 27,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74,
            76, 77, 78, // SQL
            47, 48, 49, 50, // Azure
            139 // flagship
        }, 10, 17);
        Assert.That(result, Is.EqualTo("Blue"));
    }

    [Test]
    public void TwoFullStacksShouldReturnBlack()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            5, 6, 7, 8,
            11, 12, 13,
            14, 15, 16, 17,
            18, 19, 20, 21,
            22, 23,
            24, 25, 26, 27,
            43, 44, 45, 46,
            53, 75,
            28, 72, 74,
            76, 77, 78, // SQL
            47, 48, 49, 50, // Azure
            139 // flagship
        }, 15, 25);
        Assert.That(result, Is.EqualTo("Black"));
    }
}
