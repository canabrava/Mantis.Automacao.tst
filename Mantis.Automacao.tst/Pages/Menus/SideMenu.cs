using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class SideMenu : PageBase
    {
        #region Mappping

        private By btnManageOverview = By.XPath("//*[@href='/manage_overview_page.php']");

        #endregion

        #region Actions

        public void ClickManageOverview()
        {
            Click(btnManageOverview);
        }

        #endregion

    }
}
