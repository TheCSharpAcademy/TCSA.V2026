using System.ComponentModel.DataAnnotations;

namespace TCSA.V2026.Data.Enums;

public enum Level
{
    White = 1,
    Green,
    [Display(Name = "Olive Green")]
    OliveGreen,
    Yellow,
    Orange,
    Red,
    Purple,
    Brown,
    Grey,
    Blue,
    Black
}
