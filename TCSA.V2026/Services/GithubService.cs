using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data;
using TCSA.V2026.Data.Curriculum;
using TCSA.V2026.Data.Models;
using TCSA.V2026.Data.Models.Responses;
using TCSA.V2026.Helpers;
using TCSA.V2026.Webhooks;

namespace TCSA.V2026.Services;

public interface IGithubService
{
    Task<BaseResponse> MarkAsCompleted(PullRequestReviewDto pullRequestReviewDto);
    Task<BaseResponse> ProcessPullRequest(PullRequestDto pullRequestDto);
}

public class GithubService : IGithubService
{
    private readonly IDbContextFactory<ApplicationDbContext> _factory;

    public GithubService(IDbContextFactory<ApplicationDbContext> factory)
    {
        _factory = factory;
    }

    public async Task<BaseResponse> ProcessPullRequest(PullRequestDto pullRequestDto)
    {
        if (!pullRequestDto.Action.Equals("opened"))
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = "Pull request action is not 'opened'."
            };
        }

        var projectId = GithubHelper.GetProjectId(pullRequestDto.Repository.Id);

        if (projectId == 0)
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = "Repository can't be mapped."
            };
        }

        using (var context = _factory.CreateDbContext())
        {
            var fuckingName = "TheCSharpAcademy";
            var user = await context.AspNetUsers
                .Include(u => u.DashboardProjects)
                .FirstOrDefaultAsync(u => u.GithubUsername.Trim().ToLower() == pullRequestDto.PullRequest.User.Login.Trim().ToLower());

            if (user == null)
            {
                return new BaseResponse
                {
                    Status = ResponseStatus.Fail,
                    Message = "No user found with the provided GitHub username."
                };
            }

            var projectExists = user.DashboardProjects.Any(x => x.ProjectId == projectId && !x.IsArchived);

            if (!projectExists)
            {
                await context.DashboardProjects.AddAsync(
                    new DashboardProject
                    {
                        ProjectId = projectId,
                        AppUserId = user.Id,
                        GithubUrl = pullRequestDto.PullRequest.HtmlUrl,
                        DateSubmitted = DateTime.UtcNow,
                        IsArchived = false,
                        IsCompleted = false,
                        IsPendingNotification = false,
                        IsPendingReview = true
                    });

                await context.UserActivity.AddAsync(
                    new AppUserActivity
                    {
                        ProjectId = projectId,
                        AppUserId = user.Id,
                        DateSubmitted = DateTime.UtcNow,
                        ActivityType = ActivityType.ProjectSubmitted
                    });

                await context.SaveChangesAsync();
            }
        }

        return new BaseResponse
        {
            Status = ResponseStatus.Success,
            Message = "Pull request processed successfully."
        };
    }

    public async Task<BaseResponse> MarkAsCompleted(PullRequestReviewDto pullRequestReviewDto)
    {
        if (!pullRequestReviewDto.Review.State.Equals("approved"))
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = "Pull request action is not 'approved'."
            };
        }

        var projectId = GithubHelper.GetProjectId(pullRequestReviewDto.Repository.Id);

        if (projectId == 0)
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = "Repository can't be mapped."
            };
        }

        try
        {
            var points = ProjectHelper.GetProjects().FirstOrDefault(p => p.Id == projectId).ExperiencePoints;

            using (var context = _factory.CreateDbContext())
            {
                var project = await context.DashboardProjects
                    .Include(p => p.AppUser)
                       .ThenInclude(u => u.UserActivity)
                    .FirstOrDefaultAsync(p => p.ProjectId == projectId && p.GithubUrl.Contains(pullRequestReviewDto.PullRequest.Number.ToString()));

                project.IsPendingNotification = true;
                project.IsPendingReview = false;
                project.IsCompleted = true;
                project.DateCompleted = DateTimeOffset.UtcNow;

                project.AppUser.ExperiencePoints = project.AppUser.ExperiencePoints + points;
                project.AppUser.UserActivity.Add(new AppUserActivity
                {
                    ActivityType = ActivityType.ProjectCompleted,
                    ProjectId = project.ProjectId,
                    DateSubmitted = DateTimeOffset.UtcNow
                });

                var review = await context.UserReviews
                    .Include(x => x.User)
                        .ThenInclude(u => u.UserActivity)
                    .FirstOrDefaultAsync(r => r.DashboardProjectId == project.Id);

                if (review != null)
                {
                    review.User.ExperiencePoints = review.User.ExperiencePoints + points;
                    review.User.ReviewedProjects = review.User.ReviewedProjects + 1;
                    review.User.UserActivity.Add(new AppUserActivity
                    {
                        ActivityType = ActivityType.CodeReviewCompleted,
                        ProjectId = project.ProjectId,
                        DateSubmitted = DateTimeOffset.UtcNow
                    });
                }

                await context.SaveChangesAsync();
            }
            return new BaseResponse
            {
                Status = ResponseStatus.Success,
            };
        }
        catch (Exception ex)
        {
            return new BaseResponse
            {
                Status = ResponseStatus.Fail,
                Message = ex.Message
            };
        }
    }
}

public enum GithubRepository : long
{
    MathGame = 587597495,
    Calculator = 573911382,
    HabitLogger = 573675655,
    CodingTracker = 573911543,
    Flashcards = 573911617,
    Drinks = 573911726,
    PhoneBook = 573911920,
    ShiftsLogger = 573912212,
    Ecommerce = 573912286,
    SportsResults = 675864949,
    ExcelReader = 573912431,
    UnitTesting = 573912512
}