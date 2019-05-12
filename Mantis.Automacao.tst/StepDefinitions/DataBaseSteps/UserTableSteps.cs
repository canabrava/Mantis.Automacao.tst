using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.DataBaseSteps
{
    [Binding]
    class UserTableSteps
    {
        [StepDefinition(@"o novo usuario dever ter sido criado corretamente")]
        public void ThenONovoUsuarioDeverTerSidoCriadoCorretamente()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"o novo usuario nao dever ter sido criado corretamente")]
        public void ThenONovoUsuarioNaoDeverTerSidoCriadoCorretamente()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
