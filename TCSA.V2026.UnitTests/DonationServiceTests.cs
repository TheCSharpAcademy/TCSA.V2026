using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Moq;
using Stripe;
using Stripe.Checkout;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Options;
using TCSA.V2026.Data.Models.Requests;
using TCSA.V2026.Services;

namespace TCSA.V2026.UnitTests;

public class DonationServiceTests
{
    [Test]
    public async Task Checkout_WithExistingEmptySession_UsesUniquePendingReferenceThenStripeSession()
    {
        var interceptor = new PendingReferenceInterceptor();
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .AddInterceptors(interceptor).Options;
        var factory = new Mock<IDbContextFactory<ApplicationDbContext>>();
        factory.Setup(x => x.CreateDbContextAsync(It.IsAny<CancellationToken>()))
            .ReturnsAsync(() => new ApplicationDbContext(options));
        await using (var db = new ApplicationDbContext(options))
        {
            db.UserStripe.Add(new UserStripe { AppUserId = "donor", StripeCustomerId = "cus_existing" });
            db.UserDonations.Add(new UserDonation { AppUserId = "donor", StripeCheckoutSessionId = "" });
            await db.SaveChangesAsync();
        }
        interceptor.CheckReferences = true;
        var stripe = new Mock<IStripeClient>();
        var sessionNumber = 0;
        stripe.Setup(x => x.RequestAsync<Session>(It.IsAny<HttpMethod>(), It.IsAny<string>(),
                It.IsAny<BaseOptions>(), It.IsAny<RequestOptions>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(() => new Session { Id = $"cs_{++sessionNumber}", Url = "https://checkout.stripe.com/test" });
        var service = new DonateService(factory.Object, stripe.Object,
            Options.Create(new StripeOptions { BaseUrl = "https://example.com" }), NullLogger<DonateService>.Instance);

        for (var i = 0; i < 2; i++)
        {
            var result = await service.CreateCheckoutAsync(new CreateDonationCheckoutRequest
            {
                AppUserId = "donor", Email = "donor@example.com", AmountDollars = 10
            });
            Assert.That(result.IsFailure, Is.False);
        }

        await using var verify = new ApplicationDbContext(options);
        Assert.That(interceptor.PendingReferences.Distinct().Count(), Is.EqualTo(2));
        Assert.That(await verify.UserDonations.CountAsync(x => x.StripeCheckoutSessionId.StartsWith("cs_")), Is.EqualTo(2));
    }

    private sealed class PendingReferenceInterceptor : SaveChangesInterceptor
    {
        public bool CheckReferences { get; set; }
        public List<string> PendingReferences { get; } = [];

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData,
            InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            if (CheckReferences)
            {
                foreach (var entry in eventData.Context!.ChangeTracker.Entries<UserDonation>()
                             .Where(x => x.State == EntityState.Added))
                {
                    Assert.That(entry.Entity.StripeCheckoutSessionId, Does.StartWith("pending_"));
                    PendingReferences.Add(entry.Entity.StripeCheckoutSessionId);
                }
            }
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
