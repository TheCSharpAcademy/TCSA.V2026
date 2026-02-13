using Microsoft.Playwright;

namespace TCSA.V2026.EndToEndTests;

[NonParallelizable]
[TestFixture]
public class MarkArticleAsReadTests : EndToEndTestsBase
{
    private const int _testArticleId = 30009;
    private const string _testArticleSlug = "unit-testing-for-beginners";

    [Test]
    public async Task NotLoggedInUser_CannotSeeMarkAsReadButton()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/article/{_testArticleId}/{_testArticleSlug}");

        // Act
        var markAsReadButton = Page.GetByRole(AriaRole.Button, new() { Name = "Mark as Read" });

        // Assert
        await Expect(markAsReadButton).Not.ToBeVisibleAsync();
    }

    [Test]
    public async Task LoggedInUser_CanSeeMarkAsReadButton()
    {
        // Arrange
        await LoginAsTestUserAsync("user1@example.com", "Password123!");
        await Page.GotoAsync($"{BaseUrl}/article/{_testArticleId}/{_testArticleSlug}");

        // Act
        var markAsReadButton = Page.GetByRole(AriaRole.Button, new() { Name = "Mark as Read" });

        // Assert
        await Expect(markAsReadButton).ToBeVisibleAsync();
    }

    [Test]
    public async Task LoggedInUser_CanMarkArticleAsRead()
    {
        // Arrange
        await LoginAsTestUserAsync("user1@example.com", "Password123!");
        await Page.GotoAsync($"{BaseUrl}/article/{_testArticleId}/{_testArticleSlug}");

        // Act
        var markAsReadButton = Page.GetByRole(AriaRole.Button, new() { Name = "Mark as Read" });
        await markAsReadButton.ClickAsync();

        // Assert
        var completionAlert = Page.GetByText("Article successfully marked as read");
        var completionMessage = Page.GetByText("You have completed this roadmap step.");

        await Expect(completionMessage).ToBeVisibleAsync();
        await Expect(completionAlert).ToBeVisibleAsync();
    }

    [Test]
    public async Task LoggedInUser_MarkingArticleAsRead_ShowsOnActivityPage()
    {
        // Arrange
        await LoginAsTestUserAsync("user1@example.com", "Password123!");
        await Page.GotoAsync($"{BaseUrl}/article/{_testArticleId}/{_testArticleSlug}");

        // Act
        var markAsReadButton = Page.GetByRole(AriaRole.Button, new() { Name = "Mark as Read" });
        await markAsReadButton.ClickAsync();

        await Page.GotoAsync($"{BaseUrl}/Dashboard/Activity");

        // Assert
        var activityEntry = Page.GetByText("You read the article Unit Testing");
        await Expect(activityEntry).ToBeVisibleAsync();

    }

    [Test]
    public async Task LoggedInUser_MarkingArticleAsRead_UpdatesXPDisplay()
    {
        // Arrange
        await LoginAsTestUserAsync("user1@example.com", "Password123!");

        // Get initial XP
        await Page.GotoAsync($"{BaseUrl}/Dashboard/Activity");
        var xpElement = Page.GetByTestId("user-xp");
        var initialXPText = await xpElement.TextContentAsync();
        var initialXP = int.Parse(initialXPText ?? "0");

        // Act
        await Page.GotoAsync($"{BaseUrl}/article/{_testArticleId}/{_testArticleSlug}");
        var markAsReadButton = Page.GetByRole(AriaRole.Button, new() { Name = "Mark as Read" });
        await markAsReadButton.ClickAsync();

        await Page.GotoAsync($"{BaseUrl}/Dashboard/Activity");

        // Assert
        var updatedXPText = await xpElement.TextContentAsync();
        var updatedXP = int.Parse(updatedXPText ?? "0");

        Assert.That(updatedXP, Is.EqualTo(initialXP + 1), "XP should increase by 1 when marking an article as read");
    }
}
