using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class TimeSpanFormatterTests
{
    [TestCase(0, 0, 0, 0, "just now")]
    [TestCase(2, 3, 0, 0, "2 days 3 hours ago")]
    [TestCase(1, 0, 0, 0, "1 day ago")]
    [TestCase(0, 2, 30, 0, "2 hours 30 minutes ago")]
    [TestCase(0, 1, 0, 0, "1 hour ago")]
    [TestCase(0, 0, 5, 30, "5 minutes ago")]
    public void FormatDurationOpen_ShouldReturnCorrectFormat(int days, int hours, int minutes, int seconds, string expected)
    {
        // Arrange
        var duration = new TimeSpan(days, hours, minutes, seconds);

        // Act
        var result = TimeSpanFormatter.FormatDurationOpen(duration);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
