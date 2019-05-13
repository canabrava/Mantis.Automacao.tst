using Mantis.Automacao.tst.Flows;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.NavigateSteps
{
    [Binding]
    class LoginSteps
    {
        [StepDefinition(@"eu esteja logado como administrador")]
        public void GivenEuEstejaLogadoComoAdministrador()
        {
            Login.LoginAsAdministrator();
        }

    }
}
