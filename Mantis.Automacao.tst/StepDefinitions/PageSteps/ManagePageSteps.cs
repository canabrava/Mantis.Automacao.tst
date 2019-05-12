using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ManagePageSteps
    {
        [StepDefinition(@"eu preencher as informacoes  '(.*)', '(.*)', '(.*)' e (.*)")]
        public void WhenEuPreencherAsInformacoesE(string username, string realName, string eMail, string accessLevel)
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"clicar para criar nova conta")]
        public void WhenClicarParaCriarNovaConta()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
