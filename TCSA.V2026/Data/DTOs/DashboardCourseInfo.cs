namespace TCSA.V2026.Data.DTOs;

public class DashboardCourseInfo
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public bool IsHidden { get; set; }
    public DashBoardCourseStatus Status { get; set; }
}

public enum DashBoardCourseStatus
{
    NotStarted,
    InProgress,
    Completed,
}