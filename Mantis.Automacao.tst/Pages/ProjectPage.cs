using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ProjectPage : PageBase
    {
        #region Mapping

        By btnDeleteProject = By.XPath("//*[@id='project-delete-form']");

        #endregion

        #region Actions

        public void ClickDeleteProject()
        {
            Click(btnDeleteProject);
        }

        #endregion
    }
}
