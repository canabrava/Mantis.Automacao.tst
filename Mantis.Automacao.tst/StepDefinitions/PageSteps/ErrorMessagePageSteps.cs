using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ErrorMessagePageSteps
    {
        [StepDefinition(@"eu vejo uma mensagem de que nao e possivel criar usuario com nome repetido")]
        public void ThenEuVejoUmaMensagemDeQueNaoEPossivelCriarUsuarioComNomeRepetido()
        {
            var errorPage = new ErrorMessagePage();

            Assertions.AssertTrue(errorPage.AmInAlreadyUsedUsernamePage());
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o e-mail esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueOE_MailEstaInvalido()
        {
            var errorPage = new ErrorMessagePage();

            Assertions.AssertTrue(errorPage.AmInInvalidEmailPage());
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o nome do usuario esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueONomeDoUsuarioEstaInvalido()
        {
            var errorPage = new ErrorMessagePage();

            Assertions.AssertTrue(errorPage.AmInInvalidUsernamePage());
        }


    }
}
