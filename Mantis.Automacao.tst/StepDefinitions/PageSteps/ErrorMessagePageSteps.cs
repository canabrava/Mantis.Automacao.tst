using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ErrorMessagePageSteps
    {
        ErrorMessagePage errorPage = new ErrorMessagePage();

        [StepDefinition(@"eu vejo uma mensagem de que nao e possivel criar usuario com nome repetido")]
        public void ThenEuVejoUmaMensagemDeQueNaoEPossivelCriarUsuarioComNomeRepetido()
        {
            Assertions.AssertTrue(errorPage.AmInAlreadyUsedUsernamePage());
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o e-mail esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueOE_MailEstaInvalido()
        {
            Assertions.AssertTrue(errorPage.AmInInvalidEmailPage());
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o nome do usuario esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueONomeDoUsuarioEstaInvalido()
        {
            Assertions.AssertTrue(errorPage.AmInInvalidUsernamePage());
        }

        [StepDefinition(@"eu devo ver a mensagem de que já existe um projeto com esse nome")]
        public void ThenEuDevoVerAMensagemDeQueJaExisteUmProjetoComEsseNome()
        {
            Assertions.AssertTrue(errorPage.AmInProjectAlreadyExistsPage());
        }

        [StepDefinition(@"eu devo ver a mensagem de que já existe uma categiria com esse nome")]
        public void ThenEuDevoVerAMensagemDeQueJaExisteUmaCategiriaComEsseNome()
        {
            Assertions.AssertTrue(errorPage.AmInCategoryAlreadyExistsPage());
        }

    }
}
