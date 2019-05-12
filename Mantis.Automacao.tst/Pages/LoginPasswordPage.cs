using Mantis.Automacao.tst.Bases;
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

        public bool AmInPasswordPage()
        {
            return ReturnIfElementIsDisplayed(By.XPath("//*[contains(text(),'Perdeu a sua senha?')]"));
        }

        #endregion
    }
}
