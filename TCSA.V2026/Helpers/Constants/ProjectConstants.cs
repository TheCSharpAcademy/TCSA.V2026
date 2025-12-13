using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers.Constants;

public static class ProjectConstants
{
    public static readonly List<string> ProjectlessAreas = new()
    {
        Area.StandAlone.ToString(), Area.FullStack.ToString(),
        Area.StartApplying.ToString(), Area.OpenSource.ToString(),
        Area.HowItWorks.ToString(), Area.StartHere.ToString(), Area.SQL.ToString(),
        Area.Azure.ToString(), Area.Blog.ToString(), Area.Principles.ToString(), Area.Course.ToString()
    };

    public static readonly List<int> NonApplicableProjects = new()
    {
        (int)ArticleName.StartHere, (int)ArticleName.GettingHelp, (int)ArticleName.SettingUp,
        (int)ArticleName.Foundations, (int)ArticleName.ImportanceOfConsole,
        (int)ArticleName.FreecodeCamp, (int)ArticleName.Portfolio, (int)ArticleName.Resume,
        (int)ArticleName.Sql1, (int)ArticleName.Sql2, (int)ArticleName.Sql3,
        (int)ArticleName.DeploySimpleApp, (int)ArticleName.DeployFullStack, (int)ArticleName.DeployFramework,
        (int)ArticleName.AzureFunctions
    };
}
