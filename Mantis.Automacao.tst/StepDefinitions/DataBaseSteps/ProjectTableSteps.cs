using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Models;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.DataBaseSteps
{
    [Binding]
    class ProjectTableSteps
    {

        World context = World.GetInstance();

        [StepDefinition(@"exista um projeto criado com os dados: '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void GivenExistaUmProjetoCriadoComOsDados(string nomeProjeto, string estado, string visibilidade, string descricao)
        {
            var projectTableDAO = new ProjectTableDAO();

            projectTableDAO.InsertNewProject(new ProjectModel()
            {
                name = nomeProjeto,
                status = estado,
                viewState = visibilidade,
                description = descricao
            });
        }

        [StepDefinition(@"o novo projeto deve ter sido criado corretamente")]
        public void ThenONovoProjetoDeveTerSidoCriadoCorretamente()
        {
            Assertions.AssertTrue(CreateProject.IsNewProjectInDataBase(context.GetNewProject()));
        }

        [Then(@"o projeto deve ter sido apagado")]
        public void ThenOProjetoDeveTerSidoApagado()
        {
            Assertions.AssertFalse(CreateProject.IsNewProjectInDataBase(context.GetNewProject()));
        }

    }
}
