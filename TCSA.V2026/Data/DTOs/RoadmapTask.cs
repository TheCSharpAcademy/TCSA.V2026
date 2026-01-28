namespace TCSA.V2026.Data.DTOs;

public class RoadmapTask
{
    public int Id { get; set; }
    public string IconUrl { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public bool IsProject { get; set; }
    public bool IsArticle { get; set; }
    public bool IsCompleted { get; set; }
    public List<RoadmapTask>? Subtasks { get; set; }
    public string? Tooltip { get; set; }
}