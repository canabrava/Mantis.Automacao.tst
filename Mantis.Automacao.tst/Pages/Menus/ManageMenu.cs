using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class ManageMenu : PageBase
    {

        #region Mapping

        By btnManageUsers = By.XPath("//*[@href='/manage_user_page.php]");

        By btnManageProject = By.XPath("//*[@href='/manage_proj_page.php']");

        #endregion

        #region Actions

        public void ClickManageUsers()
        {
            Click(btnManageUsers);
        }

        public void ClickManageProjects()
        {
            Click(btnManageProject);
        }

        #endregion

    }
}
