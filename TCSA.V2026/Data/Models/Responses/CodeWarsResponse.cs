using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Models.Responses;

public class CodeWarsResponse : BaseResponse
{
    public List<CodeWarsChallenge>? Challenges { get; set; }
}

public class CodeWarsApiResponse
{
    public int totalPages { get; set; }
    public int totalItems { get; set; }
    public List<CompletedChallenge> data { get; set; }
}

public class CompletedChallenge
{
    public string id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public List<string> completedLanguages { get; set; }
    public DateTime completedAt { get; set; }
}