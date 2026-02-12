using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TCSA.V2026.Data;

namespace TCSA.V2026.EndToEndTests;

public class EndToEndTestFactory : WebApplicationFactory<Program>
{
    private static readonly string DatabaseName = Guid.NewGuid().ToString();

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration((context, config) =>
        {
            config.AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["LinkProvider:DiscordLink"] = "https://discord.gg/test"
            });
        });

        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll<IDbContextFactory<ApplicationDbContext>>();
            services.RemoveAll<DbContextOptions<ApplicationDbContext>>();

            var optionsConfig = services.FirstOrDefault(d => d.ServiceType.Name.Contains("IDbContextOptionsConfiguration"));
            if (optionsConfig != null) services.Remove(optionsConfig);

            services.AddDbContextFactory<ApplicationDbContext>(options =>
            {
                options.UseInMemoryDatabase(DatabaseName);
            });
        });
    }
}
