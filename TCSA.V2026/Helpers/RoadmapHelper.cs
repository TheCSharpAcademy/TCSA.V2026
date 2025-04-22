using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class RoadmapHelper
{
    public static List<Article>? Articles = ArticleHelper.GetArticles();
    public static List<Project>? Projects = ProjectHelper.GetProjects();
    public static Project FlagshipProject = Projects.Single(x => x.Id == 139);

    public static readonly int[] GreenRequirements = { 5, 6, 7, 8, 53, 75 };
    public static readonly int[] OliveGreenRequirements = { 11, 12, 13 };
    public static readonly int[] YellowRequirements = { 14, 15, 16, 17 };
    public static readonly int[] OrangeRequirements = { 18, 19, 20, 21 };
    public static readonly int[] RedRequirements = { 22, 23 };
    public static readonly int[] GreyAndBlackRequirements = { 139 };
    public static readonly int[] AspNetRequirements = { 24, 25, 26, 27 };
    public static readonly int[] AngularRequirements = { 31, 32, 33, 34 };
    public static readonly int[] ReactRequirements = { 35, 36, 37, 38 };
    public static readonly int[] BlazorRequirements = { 39, 40, 41, 42 };
    public static readonly int[] MauiRequirements = { 43, 44, 45, 46 };
    public static readonly int[] AuthRequirements = { 28, 72, 74 };
    public static readonly int[] SqlRequirements = { 76, 77, 78 };
    public static readonly int[] AzureRequirements = { 47, 48, 49, 50 };
    public static readonly int[][] FullStackAreas = { AspNetRequirements, AngularRequirements, ReactRequirements, BlazorRequirements, MauiRequirements };
    public static readonly int[][] AspNetAreas = { AspNetRequirements, BlazorRequirements, MauiRequirements };

    public static readonly List<string> GreenBeltReqs = new()
    {
        "Read the 5 Articles below",
        "Complete Freecodecamp C# Certification",
        "Complete Math Game project"
    };
    public static readonly List<string> OliveGreenBeltReqs = new()
    {
        "Complete Calculator project",
        "Complete Habit Logger project",
        "Complete Coding Tracker project"
    };
    public static readonly List<string> YellowBeltReqs = new()
    {
        "Complete Flashcards project",
        "Complete Drinks Info project",
        "Complete Phone Book project",
        "Complete Shifts Logger project"
    };
    public static readonly List<string> OrangeBeltReqs = new()
    {
        "Complete Exercise Tracker project",
        "Complete Sports Results notifier project",
        "Complete Excel Reader project",
        "Complete Unit Testing project"
    };
    public static readonly List<string> RedBeltReqs = new()
    {
        "Complete Portfolio project",
        "Complete Resume project",
        "Complete 2 Code Reviews",
        "Complete 1 Community Project Issue"
    };
    public static readonly List<string> PurpleBeltReqs = new()
    {
        "Complete 1 Full-stack area",
        "Complete 2 Code Reviews",
        "Complete 1 Community Project Issue"
    };
    public static readonly List<string> BrownBeltReqs = new()
    {
        "Complete Auth Area",
        "Complete 3 Code Reviews",
        "Complete 2 Community Project Issues"
    };
    public static readonly List<string> GreyBeltReqs = new()
    {
        "Complete SQL Challenges",
        "Complete 5 Code Reviews",
        "Complete 3 Community Project Issues",
        "Submit a PR with Readme and Systems Design For Flagship Project"
    };
    public static readonly List<string> BlueBeltReqs = new()
    {
        "Complete Azure Area",
        "Complete 5 Code Reviews",
        "Complete 3 Community Project Issues"
    };
    public static readonly List<string> BlackBeltReqs = new()
    {
        "Complete at least 2 full-stack areas. One of them has to be MVC, Blazor or Maui",
        "Complete 8 Code Reviews",
        "Complete 5 Community Project Issues",
        "Complete Flagship Project"
    };

    public static List<RoadmapTask> missingTasks = new();
    public static List<RoadmapTask> greenBeltTasks = new();
    public static List<RoadmapTask> oliveGreenBeltTasks = new();
    public static List<RoadmapTask> yellowBeltTasks = new();
    public static List<RoadmapTask> orangeBeltTasks = new();
    public static List<RoadmapTask> redBeltTasks = new();
    public static List<RoadmapTask> purpleBeltTasks = new();
    public static List<RoadmapTask> brownBeltTasks = new();
    public static List<RoadmapTask> greyBeltTasks = new();
    public static List<RoadmapTask> blueBeltTasks = new();
    public static List<RoadmapTask> blackBeltTasks = new();

    public static List<int> completedProjects = new();
    public static List<int> mauiProjects = new();
    public static List<int> angularProjects = new();
    public static List<int> blazorProjects = new();
    public static List<int> reactProjects = new();
    public static List<int> mvcProjects = new();

    public static List<RoadmapTask> GetGreenBeltTasks(List<int> completedProjects)
    {
        var tasks = Articles
        .Where(x => x.Level == Level.Green)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsArticle = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        var greenBeltProjectTasks = Projects
        .Where(x => x.Level == Level.Green)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        tasks.AddRange(greenBeltProjectTasks);

        if (tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = greenBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }

        return tasks;
    }

    public static void GetOliveGreenBeltTasks(Level userLevel)
    {
        oliveGreenBeltTasks = Projects
        .Where(x => x.Level == Level.OliveGreen)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        if (userLevel > Level.White && oliveGreenBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = oliveGreenBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetYellowBeltTasks(Level userLevel)
    {
        yellowBeltTasks = Projects
        .Where(x => x.Level == Level.Yellow)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        if (userLevel > Level.Green && yellowBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = yellowBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetOrangeBeltTasks(Level userLevel)
    {
        orangeBeltTasks = Projects
        .Where(x => x.Level == Level.Orange)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        if (userLevel > Level.OliveGreen && orangeBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = orangeBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetRedBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        redBeltTasks = Projects
        .Where(x => x.Level == Level.Red)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        redBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 1",
                IsCompleted = reviewsCount >= 1,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 2",
                IsCompleted = reviewsCount >= 2,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 1",
                IsCompleted = issuesCount >= 1
            }
            });

        if (userLevel > Level.Yellow && redBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = redBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetPurpleBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        purpleBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "mvc.png",
                Name = "MVC",
                IsCompleted =  mvcProjects.All(x => completedProjects.Contains(x))
            },
            new RoadmapTask {
                IconUrl = "icons8-react-100.png",
                Name = "React",
                IsCompleted = reactProjects.All(x => completedProjects.Contains(x))
            },
            new RoadmapTask {
                IconUrl = "icons8-angularjs-96.png",
                Name = "Angular",
                IsCompleted = angularProjects.All(x => completedProjects.Contains(x))
            },
            new RoadmapTask {
                IconUrl = "blazor.png",
                Name = "Blazor",
                IsCompleted = blazorProjects.All(x => completedProjects.Contains(x))
            },
        });
        purpleBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 3",
                IsCompleted = reviewsCount >= 3,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 4",
                IsCompleted = reviewsCount >= 4,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 2",
                IsCompleted = issuesCount >= 2
            }
        });

        if (userLevel > Level.Orange && purpleBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = purpleBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetBrownBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        brownBeltTasks = Projects
        .Where(x => x.Level == Level.Brown)
        .Select(x => new RoadmapTask
        {
            Id = x.Id,
            IconUrl = x.IconUrl,
            Name = x.Title,
            Slug = x.Slug,
            IsProject = true,
            IsCompleted = completedProjects.Contains(x.Id)
        })
            .ToList();

        brownBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 5",
                IsCompleted = reviewsCount >= 5,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 6",
                IsCompleted = reviewsCount >= 6,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 7",
                IsCompleted = reviewsCount >= 7,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 3",
                IsCompleted = issuesCount >= 3
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 4",
                IsCompleted = issuesCount >= 4
            }
            });

        if (userLevel > Level.Red && brownBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = brownBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetGreyBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        greyBeltTasks = Projects
      .Where(x => x.Level == Level.Grey)
      .Select(x => new RoadmapTask
      {
          Id = x.Id,
          IconUrl = x.IconUrl,
          Name = x.Title,
          Slug = x.Slug,
          IsProject = true,
          IsCompleted = completedProjects.Contains(x.Id)
      })
          .ToList();

        greyBeltTasks.Add(new RoadmapTask
        {
            IconUrl = FlagshipProject.IconUrl,
            Name = FlagshipProject.Title,
            IsCompleted = false,
        });

        greyBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 8",
                IsCompleted = reviewsCount >= 8,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 9",
                IsCompleted = reviewsCount >= 9,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 10",
                IsCompleted = reviewsCount >= 10,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 11",
                IsCompleted = reviewsCount >= 11,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 12",
                IsCompleted = reviewsCount >= 12,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 5",
                IsCompleted = issuesCount >= 5,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 6",
                IsCompleted = issuesCount >= 6,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 7",
                IsCompleted = issuesCount >= 7,
            },
        });

        if (userLevel > Level.Purple && greyBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = greyBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetBlueBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        blueBeltTasks = Projects
       .Where(x => x.Level == Level.Blue)
       .Select(x => new RoadmapTask
       {
           Id = x.Id,
           IconUrl = x.IconUrl,
           Name = x.Title,
           Slug = x.Slug,
           IsProject = true,
           IsCompleted = completedProjects.Contains(x.Id)
       })
           .ToList();
        blueBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 13",
                IsCompleted = reviewsCount >= 13,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 14",
                IsCompleted = reviewsCount >= 14,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 15",
                IsCompleted = reviewsCount >= 15,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 16",
                IsCompleted = reviewsCount >= 16,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 17",
                IsCompleted = reviewsCount >= 17,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 8",
                IsCompleted = issuesCount >= 8,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 9",
                IsCompleted = issuesCount >= 9,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 10",
                IsCompleted = issuesCount >= 10,
            },
        });


        if (userLevel > Level.Brown && blueBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = greyBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
    public static void GetBlackBeltTasks(Level userLevel, int reviewsCount, int issuesCount)
    {
        blackBeltTasks.AddRange(new List<RoadmapTask> {
            new RoadmapTask {
                IconUrl = "maui.png",
                Name = "MAUI",
                IsCompleted = mauiProjects.All(x => completedProjects.Contains(x)),
                 Subtasks = Projects
                .Where(x => x.Area == Area.MAUI)
                .Select(x => new RoadmapTask
                    {
                        Id = x.Id,
                        IconUrl = x.IconUrl,
                        Name = x.Title,
                        Slug = x.Slug,
                        IsProject = true,
                        IsCompleted = completedProjects.Contains(x.Id)
                    })
                    .ToList()
            },
            new RoadmapTask {
                IconUrl = "mvc.png",
                Name = "MVC",
                IsCompleted =  mvcProjects.All(x => completedProjects.Contains(x)),
                Subtasks = Projects
                .Where(x => x.Area == Area.MVC)
                .Select(x => new RoadmapTask
                    {
                        Id = x.Id,
                        IconUrl = x.IconUrl,
                        Name = x.Title,
                        Slug = x.Slug,
                        IsProject = true,
                        IsCompleted = completedProjects.Contains(x.Id)
                    })
                    .ToList()
            },
            new RoadmapTask {
                IconUrl = "icons8-react-100.png",
                Name = "React",
                IsCompleted = reactProjects.All(x => completedProjects.Contains(x)),
                 Subtasks = Projects
                .Where(x => x.Area == Area.React)
                .Select(x => new RoadmapTask
                    {
                        Id = x.Id,
                        IconUrl = x.IconUrl,
                        Name = x.Title,
                        Slug = x.Slug,
                        IsProject = true,
                        IsCompleted = completedProjects.Contains(x.Id)
                    })
                    .ToList()
            },
            new RoadmapTask {
                IconUrl = "icons8-angularjs-96.png",
                Name = "Angular",
                IsCompleted = angularProjects.All(x => completedProjects.Contains(x)),
                 Subtasks = Projects
                .Where(x => x.Area == Area.Angular)
                .Select(x => new RoadmapTask
                    {
                        Id = x.Id,
                        IconUrl = x.IconUrl,
                        Name = x.Title,
                        Slug = x.Slug,
                        IsProject = true,
                        IsCompleted = completedProjects.Contains(x.Id)
                    })
                    .ToList()
            },
            new RoadmapTask {
                IconUrl = "blazor.png",
                Name = "Blazor",
                IsCompleted = blazorProjects.All(x => completedProjects.Contains(x)),
                 Subtasks = Projects
                .Where(x => x.Area == Area.Blazor)
                .Select(x => new RoadmapTask
                    {
                        Id = x.Id,
                        IconUrl = x.IconUrl,
                        Name = x.Title,
                        Slug = x.Slug,
                        IsProject = true,
                        IsCompleted = completedProjects.Contains(x.Id)
                    })
                    .ToList()
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 18",
                IsCompleted = reviewsCount >= 18,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 19",
                IsCompleted = reviewsCount >= 19,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 20",
                IsCompleted = reviewsCount >= 20,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 21",
                IsCompleted = reviewsCount >= 21,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 22",
                IsCompleted = reviewsCount >= 22,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 23",
                IsCompleted = reviewsCount >= 23,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 24",
                IsCompleted = reviewsCount >= 24,
            },
            new RoadmapTask {
                IconUrl = "icons8-magnifying-glass-64.png",
                Name = "Code Review 25",
                IsCompleted = reviewsCount >= 25,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 11",
                IsCompleted = issuesCount >= 11,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 12",
                IsCompleted = issuesCount >= 12,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 13",
                IsCompleted = issuesCount >= 13,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 14",
                IsCompleted = issuesCount >= 14,
            },
            new RoadmapTask {
                IconUrl = "icons8-community-96.png",
                Name = "Community Project Issue 15",
                IsCompleted = issuesCount >= 15,
            },
        });

        blackBeltTasks.Add(new RoadmapTask
        {
            IconUrl = FlagshipProject.IconUrl,
            Name = FlagshipProject.Title,
            IsCompleted = false,
        });


        if (userLevel > Level.Grey && blackBeltTasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = blackBeltTasks.Where(x => !x.IsCompleted);

            foreach (var task in incompleteTasks)
            {
                missingTasks.Add(task);
            }
        }
    }
}
