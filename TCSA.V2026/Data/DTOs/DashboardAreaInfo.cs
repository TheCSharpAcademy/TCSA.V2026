﻿using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.DTOs;

public class DashboardAreaInfo
{
    public Area Area { get; set; }
    public string Description { get; set; }
    public string ImgUrl { get; set; }
    public bool IsHidden { get; set; }
    public bool IsCompleted { get; set; }
    public string CardName { get; set; }

    public List<DashboardTaskDisplay> Tasks { get; set; }
}
