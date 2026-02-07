using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class FeedHelper
{
    public static FeedDisplay MapUserToFeedDisplay(ApplicationUser user)
    {
        return new FeedDisplay
        {
            User = user,
            ActivityType = ActivityType.NewUser,
            Date = user.CreatedDate
        };
    }

    public static FeedDisplay MapActivityToFeedDisplay(AppUserActivity activity)
    {
        return new FeedDisplay
        {
            ProjectId = activity.ProjectId,
            User = activity.ApplicationUser,
            ActivityType = activity.ActivityType,
            Date = activity.DateSubmitted,
            Level = activity.Level,
            ProjectIconUrl = ProjectHelper.GetProjectIconUrl(activity.ProjectId),
            ProjectName = ProjectHelper.GetProjectName(activity.ProjectId)
        };
    }
}
