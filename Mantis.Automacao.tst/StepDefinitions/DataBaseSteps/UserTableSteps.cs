using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.DataBaseSteps
{
    [Binding]
    class UserTableSteps
    {
        World context = World.GetInstance();

        [StepDefinition(@"o novo usuario dever ter sido criado corretamente")]
        public void ThenONovoUsuarioDeverTerSidoCriadoCorretamente()
        {
           Assertions.AssertTrue(CreateUser.IsCreatedUserInDataBase(context.GetNewUser()));
        }

        [StepDefinition(@"o novo usuario nao dever ter sido criado corretamente")]
        public void ThenONovoUsuarioNaoDeverTerSidoCriadoCorretamente()
        {
            Assertions.AssertFalse(CreateUser.IsCreatedUserInDataBase(context.GetNewUser()));
        }

    }
}
