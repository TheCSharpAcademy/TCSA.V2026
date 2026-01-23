using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;

namespace TCSA.V2026.Services;

public interface IActivityService
{
    Task DeleteDupe(int activityId);
}
public class ActivityService(IDbContextFactory<ApplicationDbContext> _factory) : IActivityService
{
    public async Task DeleteDupe(int activityId)
    {
        try
        {
            using (var context = _factory.CreateDbContext())
            {
                var activity = await context.UserActivity.FirstOrDefaultAsync(u => u.Id == activityId);

                context.UserActivity.Remove(activity!);

                await context.SaveChangesAsync();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
