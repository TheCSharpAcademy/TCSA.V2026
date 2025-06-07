namespace TCSA.V2026.Data.DTOs;

public class RoadmapStage
{
    public List<RoadmapTask> Tasks { get; set; } = new();
    public string Class { get; set; } = string.Empty;
}
