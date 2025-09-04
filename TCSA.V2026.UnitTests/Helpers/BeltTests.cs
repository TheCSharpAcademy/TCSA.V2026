using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using TCSA.V2026.Data.Helpers;
using TCSA.V2026.Data.Models;
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
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations, 
            (int) ArticleName.MathGame, (int)ArticleName.FreecodeCamp 
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void HabitCompletedShouldStillReturnGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.HabitLogger,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void CodingCompletedShouldStillReturnGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Green"));
    }

    [Test]
    public void OliveGreenCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void FlashcardsCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void DrinksCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void PhonebookCompleteShouldReturnOliveGreen()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("OliveGreen"));
    }

    [Test]
    public void ShiftsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExerciseCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, 
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void SportsCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void ExcelCompleteShouldReturnYellow()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Yellow"));
    }

    [Test]
    public void TestingCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void PortfolioCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void ResumeCompleteShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume, 
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 0, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 1, 0);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndReviewShouldReturnOrange()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 1, 1);
        Assert.That(result, Is.EqualTo("Orange"));
    }

    [Test]
    public void OneIssueAndTwoReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 1, 2);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void TwoIssuesAndFourReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList, (int) ArticleName.Budget,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughReviewsShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList,  (int) ArticleName.Budget,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 3);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void AspNetCoreCompleteButNotEnoughIssuesShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList, (int) ArticleName.Budget,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        },1, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void ReactCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.TicTacToe, (int) ArticleName.ExternalApi, (int) ArticleName.ShoppingList, (int) ArticleName.FriendsManager,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AngularCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.TourOfHeroes, (int) ArticleName.CoffeeTracker, (int) ArticleName.SleepTracker, (int) ArticleName.Quizgame,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void BlazorCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.WardrobeInventory, (int) ArticleName.MemoryGame, (int) ArticleName.FoodJournal, (int) ArticleName.SportsStatistics,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void MauiCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void JumpingAroundShouldReturnRed()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys,
            (int) ArticleName.WardrobeInventory, (int) ArticleName.MemoryGame, (int) ArticleName.FoodJournal,
            (int) ArticleName.TourOfHeroes, (int) ArticleName.CoffeeTracker, (int) ArticleName.SleepTracker,
            (int) ArticleName.TicTacToe, (int) ArticleName.ExternalApi, (int) ArticleName.ShoppingList,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList,
            (int) ArticleName.MathGame, (int) ArticleName.FreecodeCamp
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Red"));
    }

    [Test]
    public void FCCMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse, 
            (int) ArticleName.WardrobeInventory, (int) ArticleName.MemoryGame, (int) ArticleName.FoodJournal,
            (int) ArticleName.TourOfHeroes, (int) ArticleName.CoffeeTracker, (int) ArticleName.SleepTracker,
            (int) ArticleName.TicTacToe, (int) ArticleName.ExternalApi, (int) ArticleName.ShoppingList,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList,
            (int) ArticleName.MathGame
        }, 2, 4);
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void MathMissingShouldReturnWhite()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.WardrobeInventory, (int) ArticleName.MemoryGame, (int) ArticleName.FoodJournal,
            (int) ArticleName.TourOfHeroes, (int) ArticleName.CoffeeTracker, (int) ArticleName.SleepTracker,
            (int) ArticleName.TicTacToe, (int) ArticleName.ExternalApi, (int) ArticleName.ShoppingList,
            (int) ArticleName.WaterLogger, (int) ArticleName.Movies, (int)ArticleName.TodoList,
            (int) ArticleName.FreecodeCamp, 
        }, 2, 4);
        Assert.That(result, Is.EqualTo("White"));
    }

    [Test]
    public void AuthCompleteShouldReturnPurple()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.Auth, (int) ArticleName.ProductManagement, (int) ArticleName.ExternalAuth,
            (int) ArticleName.FreecodeCamp, (int) ArticleName.MathGame
        }, 2, 4);
        Assert.That(result, Is.EqualTo("Purple"));
    }

    [Test]
    public void AuthCompleteShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.Auth, (int) ArticleName.ProductManagement, (int) ArticleName.ExternalAuth,
            (int) ArticleName.FreecodeCamp, (int) ArticleName.MathGame
        }, 5, 7);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void SQLCompleteShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.Auth, (int) ArticleName.ProductManagement, (int) ArticleName.ExternalAuth,
            (int) ArticleName.Sql1, (int) ArticleName.Sql2, (int) ArticleName.Sql3,
            (int) ArticleName.FreecodeCamp, (int) ArticleName.MathGame
        }, 5, 7);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void NoFlagshipShouldReturnBrown()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.Auth, (int) ArticleName.ProductManagement, (int) ArticleName.ExternalAuth,
            (int) ArticleName.Sql1, (int) ArticleName.Sql2, (int) ArticleName.Sql3,
            (int) ArticleName.FreecodeCamp, (int) ArticleName.MathGame
        }, 7, 12);
        Assert.That(result, Is.EqualTo("Brown"));
    }

    [Test]
    public void FlagshipShouldReturnGrey()
    {
        var result = RoadmapHelper.GetExpectedBelt(new List<int> {
            (int) ArticleName.StartHere,  (int) ArticleName.GettingHelp, (int) ArticleName.SettingUp, (int) ArticleName.Foundations,
            (int) ArticleName.Calculator, (int) ArticleName.HabitLogger, (int) ArticleName.CodingTracker,
            (int) ArticleName.Flashcards, (int) ArticleName.Drinks, (int) ArticleName.PhoneBook, (int) ArticleName.ShiftsLogger,
            (int) ArticleName.Ecommerce, (int) ArticleName.SportsResults, (int) ArticleName.ExcelReader, (int) ArticleName.UnitTesting,
            (int) ArticleName.Portfolio, (int) ArticleName.Resume,
            (int) ArticleName.MauiMath, (int) ArticleName.Books, (int) ArticleName.Monkeys, (int) ArticleName.Warehouse,
            (int) ArticleName.Auth, (int) ArticleName.ProductManagement, (int) ArticleName.ExternalAuth,
            (int) ArticleName.Sql1, (int) ArticleName.Sql2, (int) ArticleName.Sql3,
            (int) ArticleName.FreecodeCamp, (int) ArticleName.MathGame,
            (int) ArticleName.Flagship,
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
