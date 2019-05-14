using Mantis.Automacao.tst.DBSteps;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.Hooks
{
    [Binding]
    class UserHooks
    {
        [AfterScenario("CriarConta")]
        public void DeleteCreatedUsers()
        {
            var userTable = new UserTableDAO();

            userTable.ClearUserTable();
        }
    }
}
