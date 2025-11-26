using TCSA.V2026.Helpers;

namespace TCSA.V2026.UnitTests.Helpers;

[TestFixture]
public class GalleryHelperTests
{
    [Test]
    public void GalleryVideoUrlFormatter_ShouldFormatUrlCorrectly()
    {
        // Arrange
        var url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        var expected = "https://www.youtube.com/embed/dQw4w9WgXcQ";

        // Act
        var result = GalleryHelper.GalleryVideoUrlFormatter(url);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("https://www.youtube.com/watch?v=dQw4w9WgXcQ")]
    [TestCase("https://www.youtube.com/watch?v=ABCDEFGHIJK")]
    public void YouTubeUrlValidator_ShouldReturnTrueForValidUrl(string url)
    {
        // Act
        var result = GalleryHelper.YouTubeUrlValidator(url);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("https://www.youtube.com/watch?x=short")]
    [TestCase("https://www.youtube.xzy/watch?v=toolong123456")]
    [TestCase("https://www.notyoutube.com/watch?v=dQw4w9WgXcQ")]
    [TestCase("")]
    [TestCase(" ")]
    public void YouTubeUrlValidator_ShouldReturnFalseForInvalidUrl(string url)
    {
        // Act
        var result = GalleryHelper.YouTubeUrlValidator(url);

        // Assert
        Assert.That(result, Is.False);
    }
}
