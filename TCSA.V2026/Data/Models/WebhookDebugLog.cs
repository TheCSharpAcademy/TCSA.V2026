using TCSA.V2026.Data.Enums;

namespace TCSA.V2026.Models;

public sealed class WebhookDebugLog
{
    public int Id { get; set; }
    public string Log { get; set; }
    public DateTime DateTime { get; set; }
    public LogType LogType { get; set; }
}