using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages.Menus
{
    class SideMenu : PageBase
    {
        #region Mappping

        private By btnManageOverview = By.XPath("//*[@href='/manage_overview_page.php']");

        private By btnCreateTask = By.XPath("//*[@href='/bug_report_page.php']");

        #endregion

        #region Actions

        public void ClickManageOverview()
        {
            Click(btnManageOverview);
        }

        public void ClickCreateTask()
        {
            Click(btnCreateTask);
        }

        #endregion

    }
}
