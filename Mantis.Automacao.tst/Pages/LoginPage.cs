using Mantis.Automacao.tst.Bases;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Resources;
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

        public ResultModel AmInLoginPage()
        {
            var amInLoginPage = ReturnIfElementIsDisplayed(btnCreateNewAccount);

            return new ResultModel()
            {
                result = amInLoginPage,
                message = amInLoginPage ? AssertionsMessages.AmInLoginPageSuccess : AssertionsMessages.AmInLoginPageFail
            };
        }

        public ResultModel IsLoginErrorMessageDisplayed()
        {
            var isLoginErrorDisplayed = ReturnIfElementIsDisplayed(loginErrorMessage);

            return new ResultModel()
            {
                result = isLoginErrorDisplayed,
                message = isLoginErrorDisplayed ? AssertionsMessages.ErrorMessageSuccess : AssertionsMessages.ErrorMessageFail
            };
        }
        #endregion

    }
}