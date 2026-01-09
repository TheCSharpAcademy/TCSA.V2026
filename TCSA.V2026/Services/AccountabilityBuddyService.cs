using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Helpers.ProjectsSubHelpers;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Models.Responses;
using static System.Net.WebRequestMethods;

namespace TCSA.V2026.Services;

public interface IAccountabilityBuddyService
{
    Task<ServiceResponse<EnableAccountabilityResponse>> EnableAsync(EnableAccountabilityRequest request);
}

public class AccountabilityBuddyService : IAccountabilityBuddyService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;
    private readonly HttpClient _httpClient;

    public AccountabilityBuddyService(IDbContextFactory<ApplicationDbContext> factory, IHttpClientFactory httpClientFactory)
    {
        _factory = factory;
        _httpClient = httpClientFactory.CreateClient();
    }


    public async Task<ServiceResponse<EnableAccountabilityResponse>> EnableAsync(EnableAccountabilityRequest request)
    {
        var httpResponse = await _httpClient.PostAsJsonAsync("http://localhost:5176/api/accountability/enable", request);

        // If your API always returns EnableAccountabilityBuddyResponse even on failure:
        var response = await httpResponse.Content.ReadFromJsonAsync<ServiceResponse<EnableAccountabilityResponse>>();

        if (response is not null)
        {
            return response;
        }

        response.IsSuccessful = false;
        response.Message = $"API call failed: {(int)httpResponse.StatusCode} {httpResponse.ReasonPhrase}";

        return response;
    }
}