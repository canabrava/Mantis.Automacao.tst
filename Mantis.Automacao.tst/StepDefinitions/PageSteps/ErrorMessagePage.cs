using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ErrorMessagePage
    {
        [StepDefinition(@"eu vejo uma mensagem de que nao e possivel criar usuario com nome repetido")]
        public void ThenEuVejoUmaMensagemDeQueNaoEPossivelCriarUsuarioComNomeRepetido()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o e-mail esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueOE_MailEstaInvalido()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"eu vejo uma mensagem de erro dizendo que o nome do usuario esta invalido")]
        public void ThenEuVejoUmaMensagemDeErroDizendoQueONomeDoUsuarioEstaInvalido()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
