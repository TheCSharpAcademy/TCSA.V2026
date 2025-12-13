namespace TCSA.V2026.Data.DTOs;

public class RoadmapResult
{
    public List<RoadmapStage> Stages { get; set; } = [];
    public List<RoadmapTask> MissingTasksForNextBelt { get; set; } = [];
}
