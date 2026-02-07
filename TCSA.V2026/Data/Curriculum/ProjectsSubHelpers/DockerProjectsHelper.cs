using TCSA.V2026.Data.Enums;
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
                LanguageHeadings = new EnglishHeadings(),
                Description = "Make your applications able to run anywhere with Docker containers",
                Area = Area.Docker,
                Level = Level.Black,
                ExperiencePoints = 50,
                DisplayOrder= 1,
                RepositoryLink = "https://github.com/TheCSharpAcademy/CodeReviews.Docker.Containers",
                Introduction = new List<Paragraph>
                {
                    new Paragraph
                    {
                        Body="Welcome to the your first Docker project! One of the coolest latest concepts popularized in the world of software development is containerization, a technique for bundling an application along with all its necessary dependencies and configurations into a single, self-contained unit: the so-called container. This container can run reliably across different computing environments, whether it's on a developer’s laptop, a test server, or in production on the cloud."
                    },
                    new Paragraph
                    {
                        Body="What makes it powerful is that containers share the host system's operating system kernel, which makes them lightweight and fast compared to traditional virtual machines. They ensure that \"it works on my machine\" becomes a thing of the past."
                    },
                    new Paragraph
                    {
                        Body="Docker is the tool that pushed containerization from a niche concept into the mainstream of modern development. With intuitive commands and a vast ecosystem, Docker allows developers to create, manage, and deploy containers effortlessly. Whether you're building microservices or deploying full-stack applications, Docker simplifies the process and empowers teams to iterate quickly with confidence."
                    }

                },
                Requirements = new List<string>
                {
                    @"You need to containerize a console app with Docker.",
                    @"The goal is to demonstrate a working application inside a container. You do NOT need to use external databases, volumes, or advanced Docker features. The Math Game is ideal for this project, since it doesn't contain any dependencies.",
                    @"You must create a Dockerfile that defines how your application is containerized. Include instructions to restore, build, and run your project.",
                    @"Your Docker image should be buildable using the 'docker build' command, and the container should be runnable with 'docker run'.",
                    @"You should include a brief README explaining how to build and run your container. Mention any dependencies or setup steps.",
                },
                Resources = new List<string>
                {

                    "<a target='_blank' href='https://learn.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows&pivots=dotnet-9-0'>Microsoft Tutorial: Containerize a .NET app</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=HvNR1LHxboM'>Youtube: C# Docker Console Application (short video)</a>",
                    "<a target='_blank' href='https://www.youtube.com/watch?v=cWMztQwIQNs'>Youtube: Docker Full Course (in-depth video)</a>",
                },
                Tips = new List<string>
                {
                    "You'll realise it's easy to get a container going without really understanding what's going on. Make sure you write notes as you go and write down questions that will inevitably arise. Use that list of questions to close knowledge gaps. It will serve as a rich reference in the future.",
                    "Don't rush through the steps, make sure you understand each step. Write your thought process (including doubts) in your Readme.",
                    "It's ok to use Docker Desktop at first, but if you do, we recommend you replicate the same actions using the CLI.",
                    "Make sure you REALLY understand what each of these are: Container, Image, Container Registry. How does a Container Relate to an Image?",
                    "On the same token, don't move on before understanding each line of your Docker file."
                },
                Challenges = new List<string>
                {
                    "Update your Dockerfile to accept command-line arguments when running the container. For example, the user could pass a difficulty level or username to the math game.",
                    "Tag your Docker image with a custom version label (e.g. 'mathgame:v1') and use that tag when running the container. This helps build awareness of image versioning and future maintainability."
                }
            },
        };
    }
}
