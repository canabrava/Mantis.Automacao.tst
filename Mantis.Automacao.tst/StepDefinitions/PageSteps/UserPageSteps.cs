using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    public class UserPageSteps
    {
        World context = World.GetInstance();
        UserPage userPage = new UserPage();

        [StepDefinition(@"eu devo entrar na pagina principal")]
        public void ThenEuDevoEntrarNaPaginaPrincipal()
        {
            Assertions.AssertTrue(userPage.upperMenu.IsUserLoggedIn(context.GetUserName()));
        }
    }
}
