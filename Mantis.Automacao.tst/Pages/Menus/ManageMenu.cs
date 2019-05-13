using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class ManageMenu : PageBase
    {

        #region Mapping

        By btnManageUsers = By.XPath("//*[@href='/manage_user_page.php1]");

        #endregion

        #region Actions

        public void ClickManageUsers()
        {
            Click(btnManageUsers);
        }

        #endregion

    }
}
