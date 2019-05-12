using Mantis.Automacao.tst.Bases;
using OpenQA.Selenium;



namespace Mantis.Automacao.tst.Pages
{
    class LoginPage : PageBase
    {

        #region Mapping

        private By txtUsername = By.Id("username");

        private By btnEntrar = By.XPath("//*[@value='Entrar']");

        private By btnCreateNewAccount = By.XPath("//*[@href='signup_page.php']");

        private By loginErrorMessage = By.XPath("//*[contains(text(), 'Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.')]");

        #endregion

        #region Actions

        public void EnterUsername(string username)
        {
            SendKeys(txtUsername, username);
        }

        public void ClickEnter()
        {
            Click(btnEntrar);
        }

        public bool AmInLoginPage()
        {
            return ReturnIfElementIsDisplayed(btnCreateNewAccount);
        }

        public bool IsLoginErrorMessageDisplayed()
        {
            return ReturnIfElementIsDisplayed(loginErrorMessage);
        }
        #endregion

    }
}