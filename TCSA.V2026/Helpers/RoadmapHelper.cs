﻿using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Helpers;

public static class RoadmapHelper
{
    private static List<int>? IncompleteTasks = new();
    private static List<Article>? Articles = ArticleHelper.GetArticles();
    private static List<Project>? Projects = ProjectHelper.GetProjects();
    private static Project FlagshipProject = Projects.Single(x => x.Id == 139);

    #region projectRequirements
    public static readonly int[] GreenRequirements = {
        (int) ArticleName.StartHere,  
        (int) ArticleName.GettingHelp, 
        (int) ArticleName.SettingUp, 
        (int) ArticleName.Foundations,
        (int) ArticleName.FreecodeCamp, 
        (int) ArticleName.MathGame
    };

    public static readonly int[] OliveGreenRequirements = {
        (int) ArticleName.Calculator, 
        (int) ArticleName.HabitLogger, 
        (int) ArticleName.CodingTracker
    };

    public static readonly int[] YellowRequirements = {
        (int) ArticleName.Flashcards, 
        (int) ArticleName.Drinks, 
        (int) ArticleName.PhoneBook, 
        (int) ArticleName.ShiftsLogger
    };

    public static readonly int[] OrangeRequirements = {
       (int) ArticleName.Ecommerce, 
       (int) ArticleName.SportsResults, 
       (int) ArticleName.ExcelReader, 
       (int) ArticleName.UnitTesting
    };

    public static readonly int[] RedRequirements = {
        (int) ArticleName.Portfolio, 
        (int) ArticleName.Resume,
    };

    public static readonly int[] GreyAndBlackRequirements = { 
        (int)ArticleName.Flagship, 
    };

    public static readonly int[] AspNetRequirements = {
        (int) ArticleName.WaterLogger, 
        (int) ArticleName.Movies, 
        (int) ArticleName.TodoList, 
        (int) ArticleName.Budget,
    };

    public static readonly int[] AngularRequirements = {
        (int) ArticleName.TourOfHeroes, 
        (int) ArticleName.CoffeeTracker, 
        (int) ArticleName.SleepTracker, 
        (int) ArticleName.Quizgame
    };

    public static readonly int[] ReactRequirements = { 
        (int)ArticleName.TicTacToe, 
        (int)ArticleName.ExternalApi, 
        (int)ArticleName.ShoppingList, 
        (int)ArticleName.FriendsManager
    };

    public static readonly int[] BlazorRequirements = {
        (int) ArticleName.WardrobeInventory, 
        (int) ArticleName.MemoryGame, 
        (int) ArticleName.FoodJournal, 
        (int) ArticleName.SportsStatistics
    };

    public static readonly int[] MauiRequirements = {
        (int) ArticleName.MauiMath, 
        (int) ArticleName.Books, 
        (int) ArticleName.Monkeys, 
        (int) ArticleName.Warehouse
    };

    public static readonly int[] AuthRequirements = {
        (int) ArticleName.Auth, 
        (int) ArticleName.ProductManagement, 
        (int) ArticleName.ExternalAuth,
    };

    public static readonly int[] SqlRequirements = {
        (int) ArticleName.Sql1, 
        (int) ArticleName.Sql2, 
        (int) ArticleName.Sql3
    };

    public static readonly int[] AzureRequirements = {
        (int) ArticleName.DeploySimpleApp, 
        (int) ArticleName.DeployFullStack, 
        (int) ArticleName.DeployFramework, 
    };

    public static readonly int[][] FullStackAreas = { 
        AspNetRequirements, 
        AngularRequirements, 
        ReactRequirements, 
        BlazorRequirements, MauiRequirements 
    };

    public static readonly int[][] AspNetAreas = { 
        AspNetRequirements, 
        BlazorRequirements, 
        MauiRequirements 
    };
    #endregion

    #region descriptions
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
    #endregion

    public static List<int> completedProjects = new();
    public static List<int> mauiProjects = ProjectHelper.GetProjects().Where(x => x.Area == Area.MAUI).Select(x => x.Id).ToList();
    public static List<int> angularProjects = ProjectHelper.GetProjects().Where(x => x.Area == Area.Angular).Select(x => x.Id).ToList();
    public static List<int> blazorProjects = ProjectHelper.GetProjects().Where(x => x.Area == Area.Blazor).Select(x => x.Id).ToList();
    public static List<int> reactProjects = ProjectHelper.GetProjects().Where(x => x.Area == Area.React).Select(x => x.Id).ToList();
    public static List<int> mvcProjects = ProjectHelper.GetProjects().Where(x => x.Area == Area.MVC).Select(x => x.Id).ToList();

    public static string GetExpectedBelt(List<int> completedProjects, int issues, int reviews)
    {
        var level = Level.White;

        level = GreenRequirements.All(completedProjects.Contains) ? Level.Green : level;
        level = (level >= Level.Green && OliveGreenRequirements.All(completedProjects.Contains)) ? Level.OliveGreen : level;
        level = (level >= Level.OliveGreen && YellowRequirements.All(completedProjects.Contains)) ? Level.Yellow : level;
        level = (level >= Level.Yellow && OrangeRequirements.All(completedProjects.Contains)) ? Level.Orange : level;

        if (level >= Level.Orange 
            && RedRequirements.All(completedProjects.Contains)
            && issues >= 1
            && reviews >= 2)
        {
            level = Level.Red;
        }

        int fullStackAreas = 0;
        if (BlazorRequirements.All(completedProjects.Contains)) { fullStackAreas += 1; }
        if (AspNetRequirements.All(completedProjects.Contains)) { fullStackAreas += 1; }
        if (ReactRequirements.All(completedProjects.Contains)) { fullStackAreas += 1; }
        if (AngularRequirements.All(completedProjects.Contains)) { fullStackAreas += 1; }
        if (MauiRequirements.All(completedProjects.Contains)) { fullStackAreas += 1; }

        if (level >= Level.Red
            && fullStackAreas >= 1
            && issues >= 2
            && reviews >= 4)
        {
            level = Level.Purple;
        }

        if (level >= Level.Purple
            && AuthRequirements.All(completedProjects.Contains)
            && issues >= 4
            && reviews >= 7)
        {
            level = Level.Brown;
        }

        if (level >= Level.Brown
            && SqlRequirements.All(completedProjects.Contains)
            && completedProjects.Contains(139)
            && issues >= 7
            && reviews >= 12)
        {
            level = Level.Grey;
        }

        if (level >= Level.Grey
            && AzureRequirements.All(completedProjects.Contains)
            && issues >= 10
            && reviews >= 17)
        {
            level = Level.Blue;
        }

        if (level >= Level.Blue
            && fullStackAreas >= 2
            && issues >= 15
            && reviews >= 25)
        {
            level = Level.Black;
        }

        return level.ToString();
    }

    public static List<RoadmapStage> GetRoadmap(Level level, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        return new List<RoadmapStage>
        {
            GetGreenBeltTasks(completedProjects),
            GetOliveGreenBeltTasks(level, completedProjects),
            GetYellowBeltTasks(level, completedProjects),
            GetOrangeBeltTasks(level, completedProjects),
            GetRedBeltTasks(level, completedProjects, reviewsCount, issuesCount),
            GetPurpleBeltTasks(level, completedProjects, reviewsCount, issuesCount),
            GetBrownBeltTasks(level, completedProjects, reviewsCount, issuesCount),
            GetGreyBeltTasks(level, completedProjects, reviewsCount, issuesCount),
            GetBlueBeltTasks(level, completedProjects, reviewsCount, issuesCount),
            GetBlackBeltTasks(level, completedProjects, reviewsCount, issuesCount),
        };
    }
    public static RoadmapStage GetGreenBeltTasks(List<int> completedProjects)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-green";

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
            var incompleteTasks = greenBeltProjectTasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;

        return result;
    }
    public static RoadmapStage GetOliveGreenBeltTasks(Level userLevel, List<int> completedProjects)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-olivegreen";

        var tasks = Projects
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

        if (userLevel > Level.White && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetYellowBeltTasks(Level userLevel, List<int> completedProjects)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-yellow";

        var tasks = Projects
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

        if (userLevel > Level.Green && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetOrangeBeltTasks(Level userLevel, List<int> completedProjects)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-orange";

        var tasks = Projects
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

        if (userLevel > Level.OliveGreen && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetRedBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-red";

        var tasks = Projects
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

        tasks.AddRange(new List<RoadmapTask> {
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

        if (userLevel > Level.Yellow && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetPurpleBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-purple";

        var tasks = new List<RoadmapTask>();
        tasks.AddRange(new List<RoadmapTask> {
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
        tasks.AddRange(new List<RoadmapTask> {
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

        if (userLevel > Level.Orange && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetBrownBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-brown";

        var tasks = Projects
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

        tasks.AddRange(new List<RoadmapTask> {
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

        if (userLevel > Level.Red && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetGreyBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-gray";

        var tasks = Projects
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

        tasks.Add(new RoadmapTask
        {
            IconUrl = FlagshipProject.IconUrl,
            Name = FlagshipProject.Title,
            IsCompleted = false,
        });

        tasks.AddRange(new List<RoadmapTask> {
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

        if (userLevel > Level.Purple && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetBlueBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-blue";

        var tasks = Projects
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

        tasks.AddRange(new List<RoadmapTask> {
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


        if (userLevel > Level.Brown && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
    public static RoadmapStage GetBlackBeltTasks(Level userLevel, List<int> completedProjects, int reviewsCount, int issuesCount)
    {
        var result = new RoadmapStage();
        result.Class = "custom-color-black";

        var tasks = new List<RoadmapTask>();

        tasks.AddRange(new List<RoadmapTask> {
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

        tasks.Add(new RoadmapTask
        {
            IconUrl = FlagshipProject.IconUrl,
            Name = FlagshipProject.Title,
            IsCompleted = false,
        });


        if (userLevel > Level.Grey && tasks.Any(x => !x.IsCompleted))
        {
            var incompleteTasks = tasks.Where(x => !x.IsCompleted).Select(x => x.Id);

            foreach (var task in incompleteTasks)
            {
                IncompleteTasks.Add(task);
            }
        }

        result.Tasks = tasks;
        return result;
    }
}
