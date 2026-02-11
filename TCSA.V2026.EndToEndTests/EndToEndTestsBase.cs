using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Playwright;
using TCSA.V2026.Data;

namespace TCSA.V2026.EndToEndTests;
public class EndToEndTestsBase : PageTest
{
    protected EndToEndTestFactory Factory;
    protected string BaseUrl => Factory.ClientOptions.BaseAddress.ToString().TrimEnd('/');

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Factory = new EndToEndTestFactory();
        Factory.UseKestrel();
        Factory.StartServer();
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Factory.Dispose();
    }

    [SetUp]
    public async Task SetUp()
    {
        using var scope = Factory.Services.CreateScope();

        await SeedData.Seed(scope.ServiceProvider);
    }

    [TearDown]
    public async Task TearDown()
    {
        using var scope = Factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await context.Database.EnsureDeletedAsync();
    }

    protected async Task LoginAsTestUserAsync(string email, string password)
    {
        await Page.GotoAsync($"{BaseUrl}/Account/Login");
        await Page.GetByLabel("Email").FillAsync(email);
        await Page.GetByLabel("Password").FillAsync(password);
        await Page.GetByRole(AriaRole.Button, new() { Name = "Log in" }).ClickAsync();
        await Page.WaitForURLAsync($"{BaseUrl}/Dashboard");
    }
}
