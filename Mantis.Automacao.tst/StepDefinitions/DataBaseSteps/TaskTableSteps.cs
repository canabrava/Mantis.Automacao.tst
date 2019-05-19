using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.DataBaseSteps
{
    [Binding]
    class TaskTableSteps
    {
        [StepDefinition(@"o sistema deve criar a tarefa")]
        public void ThenOSistemaDeveCriarATarefa()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
