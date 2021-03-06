﻿using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using Mantis.Automacao.tst.Resources;

namespace Mantis.Automacao.tst.Flows
{
    public static class Project
    {
        public static void FillNewProjectInformation(ProjectModel newProject)
        {
            var createProjectPage = new CreateProjectPage();

            createProjectPage.FillProjectName(newProject.name);
            createProjectPage.FillProjectStatus(newProject.status);
            createProjectPage.FillViewState(newProject.viewState);
            createProjectPage.FillProjectDescription(newProject.description);
        }

        public static ResultModel IsNewProjectInDataBase(ProjectModel newProject)
        {
            var projectTableDao = new ProjectTableDAO();

            var projectInDb = projectTableDao.ReturnProject(newProject.name);

            var isNewProjectInDataBase = newProject.IsEqual(projectInDb);

            return new ResultModel()
            {
                result = isNewProjectInDataBase,
                message = isNewProjectInDataBase ? AssertionsMessages.ProjectCreatedSuccess : AssertionsMessages.ProjectCreatedFail
            };
        }

        public static void FillEditedProjectInformation(ProjectModel newProject)
        {
            var projectPage = new ProjectPage();

            projectPage.FillProjectName(newProject.name);
            projectPage.FillProjectStatus(newProject.status);
            projectPage.FillViewState(newProject.viewState);
            projectPage.FillProjectDescription(newProject.description);
        }

    }
}
