namespace TCSA.V2026.EndToEndTests;

[SetUpFixture]
public class AssemblySetup
{
    public static EndToEndTestFactory Factory { get; private set; } = null!;

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
        Factory?.Dispose();
    }
}