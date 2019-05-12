using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Pages;
using NUnit.Framework;
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
            Assert.IsTrue(userPage.upperMenu.IsUserLoggedIn(context.GetUserName()));
        }
    }
}
