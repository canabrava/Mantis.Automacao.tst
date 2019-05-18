using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ProjectPageSteps
    {
        World context = World.GetInstance();
        ProjectPage projectPage = new ProjectPage();

        [StepDefinition(@"eu clicar em apagar projeto")]
        public void WhenEuClicarEmApagarProjeto()
        {
            projectPage.ClickDeleteProject();
        }

        [StepDefinition(@"eu entrar com as novas informacoes do projeto: '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenEuEntrarComAsNovasInformacoesDoProjeto(string nomeProjeto, string estado, string visibilidade, string descricao)
        {
            context.SetProject(new ProjectModel()
            {
                name = nomeProjeto,
                status = estado,
                viewState = visibilidade,
                description = descricao
            });

            Project.FillEditedProjectInformation(context.GetProject());
        }

        [StepDefinition(@"eu clicar em atualizar projeto")]
        public void WhenEuClicarEmAtualizarProjeto()
        {
            projectPage.ClickEditProject();
        }


    }
}
