using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    public class LoginPasswordPageSteps
    {
        World context = World.GetInstance();
        LoginPasswordPage passwordPage = new LoginPasswordPage();

        [StepDefinition(@"devo ir para a página de senha")]
        public void ThenDevoIrParaAPaginaDeSenha()
        {
            Assert.IsTrue(passwordPage.AmInPasswordPage());
        }

        [StepDefinition(@"eu entro com a senha '(.*)' no campo senha")]
        public void WhenEuEntroComASenhaNoCampoSenha(string password)
        {
            passwordPage.EnterPassword(password);
        }

        [StepDefinition(@"clicar em entrar no sistema")]
        public void WhenClicarEmEntrarNoSistema()
        {
            passwordPage.ClickEnter();
        }



    }
}
