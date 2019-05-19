using Mantis.Automacao.tst.DBSteps;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.Hooks
{
    [Binding]
    class CategoryHooks
    {
        [AfterScenario("Categorias")]
        public void ClearCategoryTable()
        {
            var categoryTableDAO = new CategoryTableDAO();

            categoryTableDAO.ClearCategoryTable();
        }
    }
}
