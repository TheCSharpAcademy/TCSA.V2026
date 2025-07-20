using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.LanguageModels;

namespace TCSA.V2026.Data.Helpers.ProjectsSubHelpers;

public class DockerProjectsHelper
{
    private static readonly IConfiguration Configuration;
    private static readonly string DiscordLink;

    static DockerProjectsHelper()
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
                Id = 100002,
                Title = "Intro to Docker",
                IconUrl = "icons8-container-64.png",
                BannerUrl = "intro-docker-banner.jpg",
                Slug = "intro-docker",
                Description = "Make your applications able to run anywhere with Docker containers",
                Area = Area.Docker,
                Level = Level.Black,
                ExperiencePoints = 50,
                DisplayOrder= 1,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Console.MathGame",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="In your first project you’ll build a very simple Math Game app. If this is your first time building a project indepentently, I recommend making use of the C# Academy's <a target='blank' href='https://www.youtube.com/watch?v=YUc5NZZVtjA&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'> series from our C# Foundation area</a>.This series will guide you through the process of creating a console app from the ground up, while explaining crucial C# concepts. If you have already watched it, or if you have prior experience creating C# applications, this project will be a breeze. But it’s still helpful to reinforce your knowledge."
                    },
                    new Paragraph
                    {
                        Body="You'll find challenges at the end of this project and all other projects in The C# Academy. These challenges aren't requirements. Your project will still be approved and you'll gain the correspondent experience points. However, the challenges will reinforce what you've learned. Although you might not get extra points for completing them, you'll become a better developer each time you finish a challenge."
                    }
                },
                Requirements = new List<string>
                {
                    @"You need to create a Math game containing the 4 basic operations",
                    @"The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.",
                    @"Users should be presented with a menu to choose an operation",
                    @"You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.",
                    @"You don't need to record results on a database. Once the program is closed the results will be deleted."
                },
                Resources = new List<string>
                {
                    "<a target='_blank' href='https://www.youtube.com/watch?v=iLByqqLGYEc&list=PL4G0MUH8YWiD1p5ySamqNWAaWlnwp1Vip'>Math Game Tutorial with Visual Studio</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=nnDNeJX-uBE'>Math Game Tutorial with Visual Studio Code</a>",
                },
                ResourcesIntro = "If you have previous C# experience, you might be able to complete this project without any help. If you don't, here are two tutorials you can follow if you get stuck. The first is using Visual Studio and not only creates a console app, but also a Desktop version, using .NET MAUI. The second uses Visual Studio Code and might be more suitable if you prefer it or don't have access to Visual Studio. ",
                ResourcesConclusion = "You don't need to watch the second part of this tutorial (Building a .NET Maui app), to complete this project. Only the Console App is required",
                Tips = new List<string>
                {
                    "Don't forget to ALWAYS, I mean ALWAYS have your code saved on Github (or whatever source control you use). This way you won't lose your work, and you can always refer back to it in the future. You're building a library of your own!",
                    "Don't rush through the steps, even if this tutorial is easy for you. Make sure you understand EACH WORD of the code. Leave no stone unturned.",
                    "If there's anything you don't understand, hover over the code, and you'll get an explanation of what the term means. If you still can't understand it, google is your best friend. You'll find explanations about pretty much everything in forums like stackoverflow.com.",
                    "If this is your first project, I recommend doing it twice. You'll be surprised at how much your retention increases, and how many gaps were left in the first time.",
                    $"Upon completion of your project, go to our <a target='_blank' href='{DiscordLink}'>Discord community</a> and brag about it! It's a very important step to complete a project and you should celebrate."
                },
                Challenges = new List<string>
                {
                    "Try to implement levels of difficulty.",
                    "Add a timer to track how long the user takes to finish the game.",
                    "Create a 'Random Game' option where the players will be presented with questions from random operations",
                    "To follow the <a href='/article/30006/dry-principle-csharp' target='_blank'>DRY Principle</a>, try using just one method for all games. Additionally, double check your project and try to find opportunities to achieve the same functionality with less code, avoiding repetition when possible."
                },
                Blocks = new List<Block>
                {
                    new Block
                    {
                        Title = "AI Challenge",
                        ImgUrl= "icons8-artificial-intelligence-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "This is a slightly more advanced project but it taps into the future of programming: Artificial intelligence. Can you make it so the users of your game are able to reply to the game's questions using their voice? For this you'll use Azure's Language Services. You can find a step-by-step tutorial below:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/XMJS-eQ4Y48?si=Bwbn0UZUe-thB8md"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Source Control",
                        ImgUrl = "icons8-git-96.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If this is your first tutorial, you might be tempted to skip this step and start coding. Don’t do it or you’ll learn the hard way. One day after working for many hours on a difficult problem you won’t save your work on a source control repository and for whatever reason all of it will be lost."
                            },
                            new Paragraph
                            {
                                Body = "Get into the habit of saving every line of code you ever write. I promise it will save you from many headaches. All serious developers save their work on a backup repository. The most commonly used is Github. Create an account if you haven’t yet. "
                            },
                            new Paragraph
                            {
                                Body="1. In Visual Studio, go to Git > Create Git Repository<br>2. Enter your Login Details<br>3. Click on Create and Push. "
                            },
                            new Paragraph
                            {
                                Body="✅ Done! Your repository is good to go. Don’t forget to commit and push your changes after every step!"
                            }, new Paragraph
                            {
                                Body="You can take further step and learn how to integrate Github with Visual Studio watching this tutorial:"
                            },
                            new Paragraph
                            {
                                IsVideo = true,
                                VideoUrl = "https://www.youtube.com/embed/oCvb-Q5lXb8"
                            }
                        }
                    },
                    new Block
                    {
                        Title = "Code Review",
                        ImgUrl= "icons8-code-review-64.png",
                        Paragraphs = new List<Paragraph>
                        {
                            new Paragraph
                            {
                                Body = "If you want your code to be reviewed by a member of the C# Academy, instead of creating your own repository, <a href='article/52/code-reviews' target='blank'>follow this article</a>, where you’ll learn how to create a fork from our base review repository."
                            }
                        }
                    },
                }
            },
        };
    }
}
