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

        [StepDefinition(@"o projeto deve estar salvo")]
        public void ThenOProjetoDeveEstarSalvo()
        {
            Assertions.AssertTrue(Project.IsNewProjectInDataBase(context.GetProject()));
        }

        [StepDefinition(@"o projeto deve ter sido apagado")]
        public void ThenOProjetoDeveTerSidoApagado()
        {
            Assertions.AssertFalse(Project.IsNewProjectInDataBase(context.GetProject()));
        }


    }
}
