using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.DataBaseSteps
{
    [Binding]
    class CategoryTableSteps
    {
        World context = new World();
        CategoryTableDAO categoryTableDAO = new CategoryTableDAO();

        [StepDefinition(@"exista uma categoria com o nome '(.*)'")]
        public void GivenExistaUmaCategoriaComONome(string categoryName)
        {
            categoryTableDAO.InsertNewCategory(categoryName);
        }

        [StepDefinition(@"o sistema deve criar a nova categoria")]
        public void ThenOSistemaDeveCriarANovaCategoria()
        {
            Assertions.AssertTrue(Category.IsNewCategoryInDataBase(context.GetCategory()));
        }
    }
}
