using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    public class LoginPageSteps
    {

        World context = World.GetInstance();
        LoginPage loginPage = new LoginPage();

        [StepDefinition(@"eu entro com o nome do usuário '(.*)' no campo do nome do usuário")]
        public void GivenEuEntroComONomeDoUsuarioNoCampoDoNomeDoUsuario(string userName)
        {
            context.SetUserName(userName);
            loginPage.EnterUsername(userName);
        }

        [StepDefinition(@"clicar em entrar na pagina de senha")]
        public void WhenClicarEmEntrarNaPaginaDeSenha()
        {
            loginPage.ClickEnter();
        }

        [StepDefinition(@"eu entro com o nome do usuário invalido no campo do nome do usuário")]
        public void GivenEuEntroComONomeDoUsuarioInvalidoNoCampoDoNomeDoUsuario()
        {
            loginPage.EnterUsername("UsuarioInvalido");
        }

        [StepDefinition(@"devemos ir para a página de login")]
        public void ThenDevemosIrParaAPaginaDeLogin()
        {
            Assertions.AssertTrue(loginPage.AmInLoginPage());
        }

        [StepDefinition(@"eu devo ver uma mensagem avisando que houve um erro no login")]
        public void ThenEuDevoVerUmaMensagemAvisandoQueHouveUmErroNoLogin()
        {
            Assertions.AssertTrue(loginPage.IsLoginErrorMessageDisplayed());
        }




    }
}
