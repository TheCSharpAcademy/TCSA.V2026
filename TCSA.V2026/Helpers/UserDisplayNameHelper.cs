using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class UserDisplayNameHelper
{
    public static string GetDisplayName(ApplicationUser user)
    {
        if (!string.IsNullOrWhiteSpace(user.DisplayName))
        {
            return user.DisplayName;
        }

        if (!string.IsNullOrWhiteSpace(user.UserName))
        {
            int atIndex = user.UserName.IndexOf('@');
            return atIndex > 0 ? user.UserName.Substring(0, atIndex) : user.UserName;
        }

        return "Anonymous";
    }
}
