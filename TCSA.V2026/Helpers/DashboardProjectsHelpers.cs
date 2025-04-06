using Microsoft.CodeAnalysis;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;
using Project = TCSA.V2026.Data.Models.Project;

namespace TCSA.V2026.Helpers;

public static class DashboardProjectsHelpers
{
    public static IEnumerable<Article> Articles = ArticleHelper.GetArticles();
    public static IEnumerable<Project> Projects = ProjectHelper.GetProjects().Where(x => x.IsClosed == false);

    private static string GetNotCompletedMessage(Area? area, Difficulty? difficulty, List<int> completedProjects)
    {
        var count = 0;
        var completedProjectsCount = 0;
        List<int> ids = new();

        if (area == Area.StartHere)
        {
            count = Articles.Where(x => x.Area == area).Count();
            ids = Articles.Where(x => x.Area == area).Select(x => x.Id).ToList();

            foreach (int id in ids)
            {
                if (completedProjects != null && completedProjects.Contains(id))
                {
                    completedProjectsCount += 1;
                }
            }
        }

        else if (area == Area.SQL)
        {
            count = Projects.Where(x => x.Area == Area.SQL && !x.IsClosed).Count();
            ids = Projects.Where(x => x.Area == Area.SQL).Select(x => x.Id).ToList();

            foreach (int id in ids)
            {
                if (completedProjects != null && completedProjects.Contains(id))
                {
                    completedProjectsCount += 1;
                }
            }
        }
        else if (area == Area.GraduationProject)
        {
            count = 1;
            ids = Projects.Where(x => x.Area == Area.GraduationProject).Select(x => x.Id).ToList();
        }
        else
        {
            if (difficulty != null)
            {
                count = Projects.Where(x => x.Area == area && x.Difficulty == difficulty).Count();
                ids = Projects.Where(x => x.Area == area && x.Difficulty == difficulty).Select(x => x.Id).ToList();
            }
            else
            {
                count = Projects.Where(x => x.Area == area).Count();
                ids = Projects.Where(x => x.Area == area).Select(x => x.Id).ToList();
            }

            foreach (int id in ids)
            {
                if (completedProjects != null && completedProjects.Contains(id))
                {
                    completedProjectsCount += 1;
                }
            }
        }

        return $"{completedProjects} out of {count} tasks completed";
    }

    public static Article GetProject(int projectId)
    {
        return ArticleHelper.GetArticles().FirstOrDefault(a => a.Id == projectId)
            ?? ProjectHelper.GetProjects().FirstOrDefault(p => p.Id == projectId)
            ?? CourseHelper.GetCourses().SelectMany(x => x.Articles).FirstOrDefault(a => a.Id == projectId);
    }

    public static List<DashboardAreaInfo> GetAreas(List<int> completedProjects)
    {
        return new List<DashboardAreaInfo>
        {
            new DashboardAreaInfo
            {
                CardName = "Start Here",
                ImgUrl = "icons8-baby-app-96.png",
                Projects = Articles.Where(x => x.Area == Area.StartHere),
                Description = GetNotCompletedMessage(Area.StartHere, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.StartHere, null),
            },
            new DashboardAreaInfo
            {
                CardName = "Beginner Console",
                ImgUrl = "icons8-mommy-and-me-classes-96.png",
                Projects = Projects.Where(x => x.Area == Area.Console && x.Difficulty == Difficulty.Beginner),
                Description = GetNotCompletedMessage(Area.Console, Difficulty.Beginner, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.Console, Difficulty.Beginner),
            },
            new DashboardAreaInfo
            {
                CardName = "Intermediate Console",
                ImgUrl = "icons8-teenager-64.png",
                Projects = Projects.Where(x => x.Area == Area.Console && x.Difficulty == Difficulty.Intermediate),
                Description = GetNotCompletedMessage(Area.Console, Difficulty.Intermediate, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.Console, Difficulty.Intermediate)
            },
            new DashboardAreaInfo
            {
                CardName = "Advanced Console",
                ImgUrl = "icons8-executive-64.png",
                Projects = Projects.Where(x => x.Area == Area.Console && x.Difficulty == Difficulty.Advanced),
                Description = GetNotCompletedMessage(Area.Console, Difficulty.Advanced, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.Console, Difficulty.Advanced)
            },
            new DashboardAreaInfo
            {
                CardName = "Start Applying",
                ImgUrl = "icons8-permanent-job-96.png",
                Projects = Projects.Where(x => x.Area == Area.StartApplying),
                Description = GetNotCompletedMessage(Area.StartApplying, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.StartApplying, null)
            },
            new DashboardAreaInfo
            {
                CardName = "SQL",
                ImgUrl = "icons8-sql-server-64.png",
                Projects = Projects.Where(x => x.Area == Area.SQL),
                Description = GetNotCompletedMessage(Area.SQL, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.SQL, null)
            },
            new DashboardAreaInfo
            {
                CardName = "ASP.NET Core MVC",
                ImgUrl = "mvc.png",
                Projects = Projects.Where(x => x.Area == Area.MVC),
                Description = GetNotCompletedMessage(Area.MVC, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,completedProjects, Area.MVC, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Auth Area",
                ImgUrl = "icons8-authentication-100.png",
                Projects = Projects.Where(x => x.Area == Area.Auth),
                Description = GetNotCompletedMessage(Area.Auth, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                          completedProjects, Area.Auth, null)
            },
            new DashboardAreaInfo       
            {
                CardName = "React",
                ImgUrl = "icons8-react-80.png",
                Projects = Projects.Where(x => x.Area == Area.React),
                Description = GetNotCompletedMessage(Area.React, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.React, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Angular",
                ImgUrl = "icons8-angularjs-96.png",
                Projects = Projects.Where(x => x.Area == Area.Angular),
                Description = GetNotCompletedMessage(Area.Angular, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.Angular, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Blazor",
                ImgUrl = "blazor.png",
                Projects = Projects.Where(x => x.Area == Area.Blazor),
                Description = GetNotCompletedMessage(Area.Blazor, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.Blazor, null)
            },
            new DashboardAreaInfo
            {
                CardName = "MAUI",
                ImgUrl = "maui.png",
                Projects = Projects.Where(x => x.Area == Area.MAUI),
                Description = GetNotCompletedMessage(Area.MAUI, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.MAUI, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Cloud Development",
                ImgUrl = "icons8-cloud-connection-480.png",
                Projects = Projects.Where(x => x.Area == Area.Azure),
                Description = GetNotCompletedMessage(Area.Azure, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                        completedProjects, Area.Azure, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Challenge Projects",
                ImgUrl = "icons8-challenge-64.png",
                Projects = Projects.Where(x => x.Area == Area.MonthlyChallenge),
                Description = GetNotCompletedMessage(Area.MonthlyChallenge, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles,
                    completedProjects, Area.MonthlyChallenge, null)
            },
            new DashboardAreaInfo
            {
                CardName = "Flagship Project",
                ImgUrl = "flagship.png",
                Projects = Projects.Where(x => x.Area == Area.GraduationProject).Take(1),
                Description = GetNotCompletedMessage(Area.GraduationProject, null, completedProjects),
                IsCompleted = CheckIfAreaIsCompleted(Projects, Articles, completedProjects, Area.GraduationProject, null)
            }
        };
    }

    public static bool CheckIfAreaIsCompleted(
       IEnumerable<Project> projects,
       IEnumerable<Article> articles,
       List<int> completedProjects,
       Area area,
       Difficulty? difficulty)
    {
        if (difficulty != null)
        {
            var ids = projects
                .Where(x => x.Area == area && x.Difficulty == difficulty)
                .Select(x => x.Id)
                .ToList();

            foreach (int id in ids)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
            }

            return true;
        }

        if (area != Area.StartHere)
        {
            var projectIds = projects
                .Where(x => x.Area == area)
                .Select(x => x.Id);

            foreach (int id in projectIds)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
            }
        }
        else
        {
            var articleIds = articles
                .Where(x => x.Area == Area.StartHere)
                .Select(x => x.Id);

            foreach (int id in articleIds)
            {
                if (completedProjects != null && !completedProjects.Contains(id))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
