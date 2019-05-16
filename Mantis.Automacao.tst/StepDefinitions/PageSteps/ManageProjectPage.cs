using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ManageProjectPage
    {
        [StepDefinition(@"eu clicar em apagar projeto")]
        public void WhenEuClicarEmApagarProjeto()
        {
            var projectPage = new ProjectPage();

            projectPage.ClickDeleteProject();
        }
    }
}
