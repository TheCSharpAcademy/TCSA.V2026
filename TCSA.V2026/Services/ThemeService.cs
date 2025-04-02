namespace TCSA.V2026.Services;

public sealed class ThemeService
{
    public bool IsDarkMode { get; set; }

    public void ToggleTheme()
    {
        IsDarkMode = !IsDarkMode;
    }
}
