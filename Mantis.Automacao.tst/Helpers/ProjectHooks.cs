using Mantis.Automacao.tst.DBSteps;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.Helpers
{
    [Binding]
    class ProjectHooks
    {
        [AfterScenario("Projetos")]
        public void ClearProjectsTable()
        {
            var projectTableDAO = new ProjectTableDAO();

            projectTableDAO.ClearProjectTable();
        }
    }
}
