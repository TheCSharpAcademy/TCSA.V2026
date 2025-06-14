﻿using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class FlagHelperTests
{
    [Test]
    public void GetFlag_ShouldReturnEarthImage_WhenCountryIsNullOrEmpty()
    {
        // Arrange
        string country = null;

        // Act
        var result = FlagHelper.GetFlag(country);

        // Assert
        Assert.That(result, Is.EqualTo("img/flags/earth.png"));
    }

    [Test]
    public void GetFlag_ShouldReturnEarthImage_WhenCountryNotFound()
    {
        // Arrange
        string country = "Unknown Country";

        // Act
        var result = FlagHelper.GetFlag(country);

        // Assert
        Assert.That(result, Is.EqualTo("img/flags/earth.png"));
    }

    [TestCase("Canada", "img/flags/canada.png")]
    [TestCase("United Kingdom", "img/flags/united-kingdom.png")]
    [TestCase("United States", "img/flags/united-states.png")]
    [TestCase("Brazil", "img/flags/brazil.png")]
    public void GetFlag_ShouldReturnCorrectFlagImage_WhenCountryExists(string country, string expected)
    {
        // Act
        var result = FlagHelper.GetFlag(country);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
