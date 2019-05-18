using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ProjectPage : PageBase
    {
        #region Mapping

        By fieldProjectName = By.Id("project-name");

        By fieldProjectStatus = By.Id("project-status");

        By fieldViewState = By.Id("project-view-state");

        By fieldProjectDescription = By.Id("description");

        By btnDeleteProject = By.XPath("//*[@id='project-delete-form']");

        By btnEditProject = By.XPath("//*[@class='btn btn-primary btn-white btn-round']");

        #endregion

        #region Actions

        public void FillProjectName(string projectName)
        {
            SendKeys(fieldProjectName, projectName);
        }

        public void FillProjectStatus(string projectStatus)
        {
            SendKeys(fieldProjectStatus, projectStatus);
        }

        public void FillViewState(string state)
        {
            SendKeys(fieldViewState, state);
        }

        public void FillProjectDescription(string description)
        {
            SendKeys(fieldProjectDescription, description);
        }

        public void ClickDeleteProject()
        {
            Click(btnDeleteProject);
        }

        public void ClickEditProject()
        {
            Click(btnEditProject);
        }

        #endregion
    }
}
