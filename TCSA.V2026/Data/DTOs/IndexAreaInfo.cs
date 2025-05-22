using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class IndexAreaInfo
{
    public Area Area { get; set; }
    public string Description { get; set; }
    public string TitleImgUrl { get; set; }
    public string Id { get; set; }
    public string Title { get; set; }

    public List<Project> Projects { get; set; }
}
