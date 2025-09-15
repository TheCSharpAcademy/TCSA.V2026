﻿using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.LanguageModels;

namespace TCSA.V2026.Data.Helpers.ProjectsSubHelpers;

internal static class MVCProjectsHelper
{
    private static readonly IConfiguration Configuration;
    private static readonly string DiscordLink;

    static MVCProjectsHelper()
    {
        Configuration = ServiceProviderAccessor.ServiceProvider.GetService<IConfiguration>();
        DiscordLink = Configuration["LinkProvider:DiscordLink"];
    }

    internal static List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 24,
                Title = "Water Drinking Logger",
                IconUrl = "icons8-drinking-96.png",
                BannerUrl = "pexels-igor-starkov-233202-2575440.jpg",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "water-drinking-logger",
                Description = "Build your first full-stack app with ASP.NET C# Razor Pages and ADO.NET",
                Area = Area.MVC,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 50,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.MVC.WaterLogger",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the world of Razor Pages, a simplified web application programming model offered by .NET. It removes much of the ceremony of ASP.NET MVC by adopting a file-based routing approach. Each Razor Pages file found under the Pages directory equates to an endpoint. There’s a lot of discussion in the .NET world about the pros and cons of Razor Pages vs MVC. Here at the C# Academy, we will learn both design patterns, so you’re better prepared to get your first job and excel at it. "
                    },
                    new Paragraph
                    {
                        Body="Another advantage of learning Razor Pages is that it uses Razor syntax, which is the same solution .NET uses for MVC and Blazor, the other two full-stack solutions in .NET. That means that your knowledge will be applied in many different pieces of technology. If you’re hired to work with C#, you’ll most likely work with one of these at some stage. Even companies that use front-end frameworks such as Vue, React or Angular have applications using .NET front-end solutions as part of their domain. Your knowledge will go a long way."
                    }
                },
                RequirementsIntro = "Microsoft’s documentation is very helpful in general, but the sheer amount of content sometimes can be very confusing. For that reason, we put together a video tutorial with the basics of Razor Pages. As usual, it’s project-based. The business model is very similar to our first couple of console apps, the Habit Tracker, and the Coding Tracker. In this video we’ll walk you through the project step-by-step. You might consider this “hand-holding”, and it is. But once you learn these basics, you'll have to implement a different business cases using Razor Pages. Don’t worry, we won’t hold your hand for too  long. 😁",
                Requirements = new List<string>
                {
                    "Follow the Razor Project Tutorial in the link provided, creating a list of steps with notes you think are important.",
                    "Recreate the project, with a different business case. Track something different and use different styling. Time to be creative!!",
                    "Add error handling to all your operations. You can test this by deleting the table and trying any of the CRUD operations to see what happens.",
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://www.youtube.com/watch?v=iIFAKW21d-4'>Razor Pages Youtube Tutorial</a>",
                    "<a href='https://bit.ly/3uVRjfM'>Razor Syntax Docs</a>",
                    "<a href='https://bit.ly/3MeGF9V'>Razor Pages Docs</a>",
                    "<a href='https://bit.ly/36uivZR'>Learn Razor Pages</a>",
                    "<a href='https://bit.ly/393KNLD'>Javascript Crash Course</a>",
                    "<a href='https://bit.ly/3rD1Bj7'>Bootstrap Crash Course</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/architecture/porting-existing-aspnet-apps/comparing-razor-pages-aspnet-mvc'>Microsoft: Razor Pages vs MVC</a>",
                    "<a href='https://stackoverflow.com/questions/48121928/asp-net-core-razor-pages-vs-full-mvc-core'>Stack Overflow: Razor Pages vs MVC</a>"
                },
                Tips = new List<string>
                {
                    "You'll come across many different files and pieces of code you've never seen. Study each one carefully, use the links in the resources area. You can find thorough explanations about each little piece of the code searching online."
                },
                Challenges = new List<string>
                {
                    "What if you want to allow split numbers? I.e. 2.25 cups of water, how would you change your data types?",
                    "How about letting the user decide between standard measures (big bottle, bottle, glass)",
                    "What if you want to have another habit being tracked in the same project? The limit to what you can create is the limit of your imagination.",
                    "Let's say your team decided to implement Entity Framework in all apps that currently use ADO.NET. This is a common scenario in enterprise environments. Try implementing this change. You can choose either a database-first or a code-first approach.",
                    "Use your knowledge from the Excel Reader project and let the users export their data onto a spreadsheet.",
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "Video Tutorial",
                        ImgUrl= "icons8-video-tutorial-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/iIFAKW21d-4"
                            }
                        }
                    }
                }
            },
            new Project
            {
                Id = 25,
                Title = "Movies",
                IconUrl = "icons8-movie-512.png",
                BannerUrl = "pexels-tima-miroshnichenko-7991238.jpg",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "movies",
                Description = "Build your first full-stack app with ASP.NET C# MVC and Entity Framework",
                Area = Area.MVC,
                Difficulty = Difficulty.Beginner,
                ExperiencePoints = 50,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.MVC.Movies",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the wonderful world of ASP.NET CoreMVC. You should be excited! Model-View-Controller is one of the most widely used design patterns in web development. The concepts you’ll learn apply to any language or framework, not just C#. You’ll be thinking MVC on a daily basis when you get a job."
                    },
                    new Paragraph
                    {
                        Body=".NET provides three solutions for full-stack development: Razor Pages, Blazor and MVC. MVC the most popular and it’s widely used in enterprise. While Blazor is gaining ground and more .NET teams are starting to use it, chances are you’ll have to write and/or maintain MVC code at some stage in your career."
                    },
                    new Paragraph
                    {
                        Body="For this initial tutorial we’ll be using Microsoft's official documentation. Its MVC tutorial does a very good job at explaining the basic concepts. There will be a bit of hand-holding at first. You’ll be using .NET’s “scaffolding”, a technique used to generate code at design time to support a number of common application scenarios when working with Entity Framework Core. This is necessary given MVC can feel complex when at first, but if you pay attention to each line of code, by the end of this project you’ll have a good grasp of MVC basics."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application to manage information about movies.",
                    "Users should be able to Add, Delete, Update and Read from a database, using website as the front-end.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "There needs to be a search functionality where I can search movies by name.",
                    "You should use SQL Server, not SQLite.",
                    "Once you finish the tutorial, you'll need to improve the UI. Add your personal touch with different colors, buttons, etc. The more the better.",
                    "You can't leave any unused code from the tutorials. Make sure you remove any unused controllers, unnecessary comments and whatever else you find that doesn't abide to professional standards."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc'>Microsoft Docs MVC Tutorial</a>",
                    "<a href='https://docs.microsoft.com/en-us/dotnet/architecture/porting-existing-aspnet-apps/comparing-razor-pages-aspnet-mvc'>Microsoft Docs MVC vs Razor Pages</a>",
                    "<a href='https://stackoverflow.com/questions/48121928/asp-net-core-razor-pages-vs-full-mvc-core'>Stack Overflow: MVC vs Razor Pages</a>",
                    "<a href='https://www.guru99.com/mvc-vs-mvvm.html'>MVC vs MVVM Article</a>",
                    "<a href='https://www.youtube.com/watch?v=4sosXZsdy-s&t=57s'>Bootstrap 5 Crash Course</a>"
                },
                ResourcesConclusion = $"Notice that there’s a lot of talk about Razor Pages, MVVM, MVC. Those topics can be confusing. Give these texts a good read and reach out on our <a target='_blank' href='{DiscordLink}'>Discord community</a> if it doesn’t make sense. Also notice there's a <b>bootstrap tutorial</b>. MVC by default ships with this UI framework. You might want to learn the basics to make the tweaks to the UI required. And remember, AI and Google are your best friends! 😁",
                Tips = new List<string>
                {
                    "In the Microsoft Docs MVC Tutorial, the first three chapters contain a simple controller with a view, for basic understanding of .NET MVC. Don't skip that part. But the actual Movie App code starts on Part 4. Remember to get rid of any unused code in the end!",
                    "Read every single line of the tutorial. Don't rush through the steps.",
                    "Once you're finished, push your final version to Github, create a new repository and do it again, step-by-step, there's a lot going on in MVC, and one time isn't enough.",
                    "I strongly recommend you make notes to help you connect the dots in ASP.NET MVC. There are lots of little details to learn and it will serve as a reference for your future MVC projects."
                },
                Challenges = new List<string>
                {
                    "Scaffolding means you're using .NET's tools to generate code for you. A very nice challenge for better retention would be to recreate the same project without scaffolding. It's ok if you copy and paste chunks of code from the original project. It will still be helpful.",
                    "Once you've done it twice, do it a third time, but with different data. Intead of movies, countries? Cars? Music? Sports? Anything, it will further cement your knowledge.",
                    "\r\nAdd one or more separate areas to the app. TV Series, for example. Or music. You'd have to create different pages for each, and a link in the nav bar."
                }
            },
            new Project
            {
                Id = 26,
                Title = "Todo List",
                IconUrl = "todo.png",
                BannerUrl = "todo-banner.jpg",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "todo-list",
                Description = "Build your first MVC application with C#, Razor Syntax, Javascript and Bootstrap",
                Area = Area.MVC,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.MVC.Todo",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In our previous project we dove into Microsoft’s Beginner MVC Tutorial and created our first full-stack application. In that app, each action has a dedicated page. However, what happens if I want to have a single page application and not open a new page every time they want to create, delete or update their data? This is what we will build now."
                    },
                    new Paragraph
                    {
                        Body="For this project we will pull from a few different resources. You'll will be introduced to “minimal APIs” and working with “Fetch API”, which will help us with moving data around asynchronously. We strongly suggest you push yourself and complete the challenges. In such a competitive market <b>the ability to solve difficult problems</b> will make you stand out. "
                    },
                    new Paragraph
                    {
                        Body="Get ready, now it really gets fun! You’ll finish this project understanding how C#, Javascript and Bootstrap work together.  From here, the limit to what you’ll be able to build will be close to the limit of your imagination. 😁"
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should manage a todo list.",
                    "Users should be able to Add, Delete, Update and Read from a database, using a SPA (single-page application). The user should never be redirected to a new page.",
                    "You need to write a minimal API to connect the front-end and database.",
                    "You need to use the JS Fetch API from your front-end to call your minimal API in the backend.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "You don't need a navigation bar. No menu is necessary since you'll only have one page.",
                    "Once you execute any operation, the todo-list needs to be automatically updated accordingly.",
                    "Your data model is only one table with to-dos. You. might be tempted to create more complex data-models (categories of todos for example) but avoid that for now. We're focusing on the front-end.",
                    "When deleting, present an 'Are you sure?' confirmation message",
                    "Upon updating, present a message saying the record hasn't been updated until the user submits the new todo. Then present a success message.",
                    "You need to add validation. For example, empty input shouldn't be allowed. Feel free to add more validations as you see fit.",
                    "You need to handle errors gracefully, with a relevant error message presented to the user."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-8.0&tabs=visual-studio'>Microsoft docs tutorial on minimal APIs",
                    "<a target='blank' href='https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-javascript?view=aspnetcore-8.0'>Microsoft docs tutorial on calling a web API in Javascript",
                    "<a target='blank' href='https://www.youtube.com/watch?v=vbbhsGzCyZQ'>MVC + Fetch API + Web API Video Tutorial</a>",
                    "<a target='blank' href='https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch'>Fetch API Docs</a>",
                    "<a target='blank' href='https://www.youtube.com/watch?v=Oive66jrwBs'>Fetch API crash course on Youtube</a>"
                },
                Challenges = new List<string>
                {
                    "Seed 1000 todos and see what types of challenges it poses to the UX.",
                    "Add a caching system so that if nothing has changed the database won't be called, saving precious resources.",
                    "Add a calendar component to show the tasks based on their due date."
                },
                Tips = new List<string>
                {
                    "When learning to connect JS to your MVC App, take a step-by-step approach: First try to call a simple alert, then try to send data to and from the controller into JS.",
                    "Use your browser dev tools to set breakpoints in the JS to help you debug when working together with C#.",
                    "The tutorial about calling APIs with JS uses MongoDB. If it adds too much confusion, just connect your App to a SQL server or SQLite solution instead. The focus right now is on the front-end."
                }
            },
            new Project
            {
                Id = 27,
                Title = "Budget",
                IconUrl = "icons8-budget-512.png",
                BannerUrl = "budget-banner.jpg",
                LanguageHeadings = new EnglishHeadings(),
                Slug = "budget",
                Description = "Build a personal finance app with multiple related tables in the back-end",
                Area = Area.MVC,
                ExperiencePoints = 50,
                Difficulty = Difficulty.Beginner,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.MVC.Budget",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Personal finances apps are very useful for learning web development. They’ll force you to handle many data types: Dates, strings, decimals, integers, just to mention the most basic. They’ll also challenge your front-end skills with heavy user interaction through forms and data-tables."
                    },
                    new Paragraph
                    {
                        Body="In terms of database design, they give you the chance to create interesting structures, such as one-to-many and many-to-many relationships between tables, which in turn expands pushes the boundaries of our knowledge of SQL and Entity Framework. So let’s build a budget app to expand on our MVC knowledge with a slightly more complex piece of software."
                    }
                },
                Requirements = new List<string>
                {
                    "This is an application where you should record personal finance transactions.",
                    "You should have at least two linked tables: Transaction and Category.",
                    "You need to use Entity Framework, raw SQL isn't allowed.",
                    "Each transaction MUST have a category and if you delete a category all it's transactions should be deleted.",
                    "You should use SQL Server, not SQLite.",
                    "You should have a search functionality where I can search transactions by name",
                    "You should have a filter functionality, so I can show transactions per category and per date.",
                    "You need to use modals to insert, delete and update transactions and categories. These operations shouldn't be done in a different page."
                },
                ResourcesIntro = "Here are a few resources that might be helpful.",
                Resources = new List<string>
                {
                    "<a href='https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-simple-key%2Csimple-key'>Relationships in EF Core</a>",
                    "<a href='https://www.learnentityframeworkcore.com/configuration/one-to-many-relationship-configuration'>One-To-Many Relationship in EF Core</a>",
                    "<a href='https://www.youtube.com/watch?v=eHT6G912po0'>One-To-Many Relationship in EF Core on Youtube</a>"
                },
                Challenges = new List<string>
                {
                    "Seed 1000 random records across 10 categories.",
                    "Include pagination so the users can't see more than 20 items per page.",
                    "Change the result of the search upon every change of the search input, without the need for the button the be clicked.",
                    "Add a Recurring Expense functionality. An expense that will automatically add itself at a given time interval.",
                    "Add caching capabilities to your app so you don't need to query the database if no changes have been detected."
                },
                Tips = new List<string>
                {
                    "Don't forget validation! Your form shouldn't allow the user to input negatives or strings as a transaction value. Data annotations on your model are one way to go.",
                    "Have separate controllers for Categories and Transactions.",
                    "Since this is the last project in this area, try building a beautiful front-end that stands out. If you think you're 'bad at design' Search on the internet for similar good-looking apps and try to mimic them."
                }
            },
        };
    }
}
