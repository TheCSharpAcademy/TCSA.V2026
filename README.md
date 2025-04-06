# The C# Academy

Welcome to The C# Academy codebase! This repository is the main platform that powers our learning community and serves as a collaborative space for developers of all skill levels.

The C# Academy website is more than just a learning platform - it's a living project where community members can practice real-world development skills. By contributing to this codebase, you'll experience what it's like to work on a production application maintained by multiple developers.

## 🛠️ Getting Started

### Community Issues

1. Browse the Community Issues / Create a new Community Issue at

   https://github.com/users/TheCSharpAcademy/projects/23

   - Assign yourself to the issue
   - Create a new branch for your issue
   - You may require permissions on the repository to perform these steps - reach out on Discord.

2. Create a new Issue (if one doesn't already exists) at

   https://www.thecsharpacademy.com/dashboard/community

   - Select the project.
   - Select the issue type.
   - Enter the issue title from step 1.
   - Enter the issue url from step 1.
   - Submit.

### Installation Prerequisites

- An IDE (code editor) like Visual Studio or Visual Studio Code.
- The .NET 9 SDK.
- An SQL Server installation (Developer, Express, Docker Container)
- A database management tool like SQL Server Management Studio or DBeaver (optional, only required if you need to run the `GetRanking` stored procedure).

### Installation Steps

> [!NOTE]
> The following steps are examples for terminal/command prompt.
>
> You may need to adjust them based on your specific operating system and environment.

1. Clone the repository:

   - `git clone https://github.com/TheCSharpAcademy/TCSA.V2026.git`

2. Navigate to the application project directory:

   - `cd TCSA.V2026\TCSA.V2026`

3. Create a `appsettings.json` file:

   - `notepad appsettings.json`

4. Paste the following, adjust any values specific to your environment. Save and close.

> [!Tip]
> Replace `DefaultConnection` with your own connection string.
>
> If you want to login via GitHub, replace `GithubClientId` and `GithubClientSecret` with you own values.
>
> https://docs.github.com/en/apps/oauth-apps/building-oauth-apps/creating-an-oauth-app

```
{
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=TCSA_V2; Integrated Security=true;"
    },
    "Logging": {
        "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
        }
    },
    "Values": {
        "GithubClientId": "",
        "GithubClientSecret": ""
    }
}
```

5. Open the solution `TCSA.V2026.sln`.

6. Go to `Program.cs` and uncomment lines 92 and 93:

> [!Warning]
> This step is not currently implemented.

```
using (var scope = app.Services.CreateScope())
{
  var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    //dbContext.Database.EnsureDeleted();
    //dbContext.Database.EnsureCreated();
}
```

7. Run the project.

#### GetRanking Store Procedure

> [!IMPORTANT]  
> This stored procedure must be created if you want to access the leaderboard pages.
>
> Use your database management tool of choice and ensure you are connected to the correct database before running the below script.

```
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetRanking]
    @userId NVARCHAR(450),
    @ranking INT OUTPUT
AS
BEGIN
    DECLARE @userExperiencePoints INT;

    -- Get the user's experience points based on the provided user ID
    SELECT @userExperiencePoints = [ExperiencePoints]
    FROM [AspNetUsers]
    WHERE [Id] = @userId;

    -- Calculate the user's ranking
    SELECT @ranking = COUNT(*) + 1
FROM [AspNetUsers]
WHERE [ExperiencePoints] > @userExperiencePoints
   OR ([ExperiencePoints] = @userExperiencePoints AND (
       [FirstName] < (SELECT [FirstName] FROM [AspNetUsers] WHERE [Id] = @userId) OR
       ([FirstName] = (SELECT [FirstName] FROM [AspNetUsers] WHERE [Id] = @userId) AND [LastName] < (SELECT [LastName] FROM [AspNetUsers] WHERE [Id] = @userId))
   ));
END;
GO
```
