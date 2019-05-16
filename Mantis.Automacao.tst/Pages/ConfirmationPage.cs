using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Pages
{
    class ConfirmationPage : PageBase
    {
        #region Mapping

        By btnConfirmDeleteProject = By.XPath("//*[@class='btn btn-primary btn-white btn-round'] ");

        #endregion

        #region Actions

        public void ClickConfimerDeleteProject()
        {
            Click(btnConfirmDeleteProject);
        }

        #endregion
    }
}
