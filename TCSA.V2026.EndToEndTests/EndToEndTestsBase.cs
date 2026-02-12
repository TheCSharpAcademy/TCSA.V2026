using Microsoft.EntityFrameworkCore;
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
    public async Task OneTimeTearDown()
    {
        await Factory.DisposeAsync();
    }

    [SetUp]
    public async Task SetUp()
    {
        await SeedData.Seed(Factory.Services);
    }

    [TearDown]
    public async Task TearDown()
    {
        using var scope = Factory.Services.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<ApplicationDbContext>>();

        await using var context = await contextFactory.CreateDbContextAsync();
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
