using Microsoft.Playwright;

namespace TCSA.V2026.EndToEndTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class LoginPageTests : EndToEndTestsBase
{
    [Test]
    public async Task Login_WithValidCredentials_ShouldRedirectToDashboard()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/Account/Login");

        // Act
        await Page.GetByLabel("Email").FillAsync("user1@example.com");
        await Page.GetByLabel("Password").FillAsync("Password123!");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in", Exact = true }).ClickAsync();

        // Assert
        await Expect(Page).ToHaveURLAsync($"{BaseUrl}/");
    }

    [Test]
    public async Task Login_WithInvalidCredentials_ShouldShowErrorMessage()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/Account/Login");

        // Act
        await Page.GetByLabel("Email").FillAsync("test@test.com");
        await Page.GetByLabel("Password").FillAsync("WrongPassword!");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in", Exact = true }).ClickAsync();

        // Assert
        await Expect(Page).ToHaveURLAsync($"{BaseUrl}/Account/Login");
        await Expect(Page.GetByText("Invalid login attempt.")).ToBeVisibleAsync();
    }

    [Test]
    public async Task Login_WithEmptyEmail_ShouldShowEmailRequiredValidationError()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/Account/Login");

        // Act
        await Page.GetByLabel("Password").FillAsync("Password123!");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in", Exact = true }).ClickAsync();

        // Assert
        await Expect(Page).ToHaveURLAsync($"{BaseUrl}/Account/Login");
        await Expect(Page.GetByText("The Email field is required.")).ToBeVisibleAsync();
    }

    [Test]
    public async Task Login_WithInvalidEmailFormat_ShowShouldInvalidEmailValidationError()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/Account/Login");

        // Act
        await Page.GetByLabel("Email").FillAsync("invalid-email");
        await Page.GetByLabel("Password").FillAsync("Password123!");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in", Exact = true }).ClickAsync();

        // Assert
        await Expect(Page).ToHaveURLAsync($"{BaseUrl}/Account/Login");
        await Expect(Page.GetByText("The Email field is not a valid e-mail address.")).ToBeVisibleAsync();
    }

    [Test]
    public async Task Login_WithEmptyPassword_ShouldShowPasswordRequiredValidationError()
    {
        // Arrange
        await Page.GotoAsync($"{BaseUrl}/Account/Login");

        // Act
        await Page.GetByLabel("Email").FillAsync("test@gmail.com");
        await Page.GetByLabel("Password").FillAsync("");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in", Exact = true }).ClickAsync();

        // Assert
        await Expect(Page).ToHaveURLAsync($"{BaseUrl}/Account/Login");
        await Expect(Page.GetByText("The Password field is required.")).ToBeVisibleAsync();
    }
}
