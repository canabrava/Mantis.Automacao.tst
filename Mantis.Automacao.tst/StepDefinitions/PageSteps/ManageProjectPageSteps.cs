using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ManageProjectPageSteps
    {
        World context = World.GetInstance();
        ManageProjectPage manageProjectPage = new ManageProjectPage();

        [StepDefinition(@"o sistema deve me levar para a pagina de gerenciar projetos")]
        public void ThenOSistemaDeveMeLevarParaAPaginaDeGerenciarProjetos()
        {
            Assertions.AssertTrue(manageProjectPage.AmInManageProjectPage());
        }

        [StepDefinition(@"eu preencher o nome da categoria com '(.*)'")]
        public void WhenEuPreencherONomeDaCategoriaCom(string nomeCategoria)
        {
            context.SetCategory(nomeCategoria);

            manageProjectPage.FillCategory(nomeCategoria);
        }

        [StepDefinition(@"clicar em adicionar categoria")]
        public void WhenClicarEmAdicionarCategoria()
        {
           manageProjectPage.ClickAddCategory();
        }

    }
}
