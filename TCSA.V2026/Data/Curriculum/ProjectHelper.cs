﻿using TCSA.V2026.Data.DTOs;
using TCSA.V2026.Data.Helpers.ProjectsSubHelpers;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data.Curriculum;

public static class ProjectHelper
{
    public static List<Project> GetProjects()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjects())
            .Concat(ConsoleProjectsHelper.GetProjects())
            .Concat(StartApplyingProjectsHelper.GetProjects())
            .Concat(MVCProjectsHelper.GetProjects())
            .Concat(AngularProjectsHelper.GetProjects())
            .Concat(BlazorProjectsHelper.GetProjects())
            .Concat(ReactProjectsHelper.GetProjects())
            .Concat(SqlProjectsHelper.GetProjects())
            .Concat(AuthProjectsHelper.GetProjects())
            .Concat(AzureProjectsHelper.GetProjects())
            .Concat(MauiProjectsHelper.GetProjects())
            .Concat(ChallengeProjectsHelper.GetProjects())
            .Concat(OpenSourceProjectsHelper.GetProjects())
            .Concat(DockerProjectsHelper.GetProjects())
            .ToList();
    }

    public static List<ShowcaseProjectInfo> GetProjectInfos()
    {
        return GetProjects().Select(project => new ShowcaseProjectInfo
        {
            Id = project.Id,
            Title = project.Title,
            Area = project.Area,

        }).ToList();
    }

    public static List<Project> GetProjectsInPortuguese()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInPortuguese())
            .Concat(ConsoleProjectsHelper.GetProjectsInPortuguese())
            .ToList();
    }

    public static List<Project> GetProjectsInDutch()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInDutch())
            .Concat(ConsoleProjectsHelper.GetProjectsInDutch())
            .ToList();
    }

    public static List<Project> GetProjectsInTurkish()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInTurkish())
            .Concat(ConsoleProjectsHelper.GetProjectsInTurkish())
            .ToList();
    }

    public static List<Project> GetProjectsInTraditionalChinese()
    {
        var projects = new List<Project>();
        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInTraditionalChinese())
            .ToList();
    }

    public static List<Project> GetProjectsInKorean()
    {
        var projects = new List<Project>();
        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInKorean())
            .Concat(ConsoleProjectsHelper.GetProjectsInKorean())
            .ToList();
    }

    public static List<Project> GetProjectsInCroatian()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInCroatian())
            .ToList();
    }

    public static List<Project> GetProjectsInRussian()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInRussian())
            .Concat(ConsoleProjectsHelper.GetProjectsInRussian())
            .ToList();
    }

    public static List<Project> GetProjectsInPolish()
    {
        var projects = new List<Project>();

        return projects
            .Concat(StandAloneProjectsHelper.GetProjectsInPolish())
            .ToList();
    }
}
