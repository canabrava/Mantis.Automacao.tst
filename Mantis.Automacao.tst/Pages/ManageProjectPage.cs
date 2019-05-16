using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ManageProjectPage : PageBase
    {
        #region Mapping

        By btnCreateNewProject = By.XPath("//*[contains(text(), 'Criar Novo Projeto')]");

        #endregion

        #region Actions

        public void ClickCreateNewProject()
        {
            Click(btnCreateNewProject);
        }

        public void ClickProject(int projectID)
        {
            Click(By.XPath("//*[@href='manage_proj_edit_page.php?project_id=" + projectID + "']"));
        }
        #endregion
    }
}
