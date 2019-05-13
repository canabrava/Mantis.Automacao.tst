using Mantis.Automacao.tst.Pages;
using System.Configuration;

namespace Mantis.Automacao.tst.Flows
{
    public static class Login
    {

        public static void LoginAsAdministrator()
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
