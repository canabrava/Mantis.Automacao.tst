using Mantis.Automacao.tst.Pages;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.NavigateSteps
{
    [Binding]
    class LoginSteps
    {
        [StepDefinition(@"eu esteja logado como administrador")]
        public void GivenEuEstejaLogadoComoAdministrador()
        {
            LoginPage loginPage = new LoginPage();
            LoginPasswordPage loginPasswordPage = new LoginPasswordPage();

            loginPage.EnterUsername(ConfigurationSettings.AppSettings["admin_username"]);
            loginPage.ClickEnter();

            loginPasswordPage.EnterPassword(ConfigurationSettings.AppSettings["admin_password"]);
            loginPasswordPage.ClickEnter();
        }

    }
}
