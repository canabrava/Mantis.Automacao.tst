using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ManageProjectPageSteps
    {
        ManageProjectPage manageProjectPage = new ManageProjectPage();

        [StepDefinition(@"o sistema deve me levar para a pagina de gerenciar projetos")]
        public void ThenOSistemaDeveMeLevarParaAPaginaDeGerenciarProjetos()
        {
            Assertions.AssertTrue(manageProjectPage.AmInManageProjectPage());
        }

    }
}
