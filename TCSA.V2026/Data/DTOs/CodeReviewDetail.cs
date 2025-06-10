namespace TCSA.V2026.Data.DTOs;

public class CodeReviewDetail
{
    public int ProjectId { get; set; }
    public int DashboardProjectId { get; set; }
    public string GithubUrl { get; set; }
    public bool IsCompleted { get; set; }
    public string UserName { get; set; }
    public string ProjectName { get; set; }
}
