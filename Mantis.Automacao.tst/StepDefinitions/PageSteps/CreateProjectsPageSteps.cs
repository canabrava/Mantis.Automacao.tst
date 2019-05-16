using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class CreateProjectsPageSteps
    {
        World context = World.GetInstance();

        [StepDefinition(@"eu preencher as informacoes do novo projeto: '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenEuPreencherAsInformacoesDoNovoProjeto(string nomeProjeto, string estado, string visibilidade, string descricao)
        {
            context.SetNewProject(new ProjectModel() {
                name = nomeProjeto,
                status = estado,
                viewState = visibilidade,
                description = descricao
            });

            CreateProject.FillNewProjectInformation(context.GetNewProject());
        }

        [StepDefinition(@"clicar para criar um novo projeto")]
        public void WhenClicarParaCriarUmNovoProjeto()
        {
            var createProjectPage = new CreateProjectPage();

            createProjectPage.ClickAddProject();
        }
    }
}
