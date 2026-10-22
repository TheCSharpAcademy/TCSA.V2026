using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using MudBlazor.Services;
using System.Security.Claims;
using TCSA.V2026.Components.Pages;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Requests;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Services;
using Error = TCSA.V2026.Data.Models.Responses.Error;

namespace TCSA.V2026.UnitTests.Components.Pages;

[TestFixture]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class ContributeTests : BunitContext
{
    private readonly Mock<IUserService> _users = new();
    private readonly Mock<IDonateService> _donations = new();

    [SetUp]
    public void SetUp()
    {
        JSInterop.Mode = JSRuntimeMode.Loose;
        Services.AddMudServices();
        Services.AddSingleton(_users.Object);
        Services.AddSingleton(_donations.Object);
        var auth = AddAuthorization();
        auth.SetAuthorized("Donor");
        auth.SetClaims(new Claim(ClaimTypes.NameIdentifier, "donor"));
        _users.Setup(x => x.GetUserProfileById("donor"))
            .ReturnsAsync(new ApplicationUser { Id = "donor", Email = "donor@example.com" });
        _donations.Setup(x => x.GetDonationsAsync())
            .ReturnsAsync(Result.Success(new List<UserDonation>()));
    }

    [Test]
    public void PresetAndCheckoutButtons_SendSelectedAmount()
    {
        _donations.Setup(x => x.CreateCheckoutAsync(It.IsAny<CreateDonationCheckoutRequest>()))
            .ReturnsAsync(Result.Failure<CreateDonationCheckoutResponse>(new Error("Checkout.Unavailable", "Checkout unavailable")));
        var cut = Render<Contribute>();

        cut.FindAll("button").Single(x => x.TextContent.Trim() == "$25").Click();
        cut.FindAll("button").Single(x => x.TextContent.Contains("Contribute with Stripe")).Click();

        _donations.Verify(x => x.CreateCheckoutAsync(It.Is<CreateDonationCheckoutRequest>(r =>
            r.AmountDollars == 25 && r.AppUserId == "donor" && r.Email == "donor@example.com")), Times.Once);
        Assert.That(cut.Markup, Does.Contain("Checkout unavailable"));
    }

    [Test]
    public void ProfileLookupFails_PresetButtonsRemainUsable()
    {
        _users.Setup(x => x.GetUserProfileById("donor")).ThrowsAsync(new InvalidOperationException("Unavailable"));
        var cut = Render<Contribute>();

        cut.FindAll("button").Single(x => x.TextContent.Trim() == "$50").Click();

        Assert.That(cut.Find("input").GetAttribute("value"), Is.EqualTo("50"));
        Assert.That(cut.Markup, Does.Contain("Could not load your profile. Please try again."));
    }

    [Test]
    public void MissingProfile_CheckoutShowsErrorWithoutCrashing()
    {
        _users.Setup(x => x.GetUserProfileById("donor")).ReturnsAsync((ApplicationUser?)null);
        var cut = Render<Contribute>();

        cut.FindAll("button").Single(x => x.TextContent.Contains("Contribute with Stripe")).Click();

        Assert.That(cut.Markup, Does.Contain("You must be logged in to contribute."));
        _donations.Verify(x => x.CreateCheckoutAsync(It.IsAny<CreateDonationCheckoutRequest>()), Times.Never);
    }
}
