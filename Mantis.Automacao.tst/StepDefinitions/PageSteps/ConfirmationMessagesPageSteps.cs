using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ConfirmationMessagesPageSteps
    {
        [StepDefinition(@"eu tenho a confirmacao de que o usuario foi criado corretamente")]
        public void ThenEuTenhoAConfirmacaoDeQueOUsuarioFoiCriadoCorretamente()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
