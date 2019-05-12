using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
using OpenQA.Selenium;


namespace Mantis.Automacao.tst.Pages
{
    class LoginPasswordPage : PageBase
    {
        #region Mapping

        private By txtPassword = By.XPath("//*[@id='password']");

        private By btnEntrar = By.XPath("//*[@value='Entrar']");

        #endregion

        #region Actions

        public void EnterPassword(string password)
        {
            SendKeys(txtPassword, password);
        }

        public void ClickEnter()
        {
            Click(btnEntrar);
        }

        public ResultModel AmInPasswordPage()
        {
            var amInPasswordPage = ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(),'Perdeu a sua senha?')]"));

            return new ResultModel()
            {
                result = amInPasswordPage,
                message = amInPasswordPage ? AssertionsMessages.AmInPasswordPageSuccess : AssertionsMessages.AmInPasswordPageFail
            };
        }

        #endregion
    }
}
