using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ConfirmationPageSteps
    {
        [StepDefinition(@"confirmar a que o projeto será deletado")]
        public void WhenConfirmarAQueOProjetoSeraDeletado()
        {
            var confirmPage = new ConfirmationPage();

            confirmPage.ClickConfimerDeleteProject();
        }
    }
}
