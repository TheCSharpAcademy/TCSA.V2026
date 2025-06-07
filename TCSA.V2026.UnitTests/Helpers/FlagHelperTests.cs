using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class FlagHelperTests
{
    public void GetFlag_ShouldReturnEarthImage_WhenCountryIsNullOrEmpty()
    {
        // Arrange
        string country = null;

        // Act
        var result = FlagHelper.GetFlag(country);

        // Assert
        Assert.That(result, Is.EqualTo("img/flags/earth.png"));
    }
}
