using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class ManagePageSteps
    {
        World context = World.GetInstance();

        [StepDefinition(@"eu preencher as informacoes  '(.*)', '(.*)', '(.*)' e (.*)")]
        public void WhenEuPreencherAsInformacoesE(string username, string realName, string email, string accessLevel)
        {
            context.SetNewUser(new UserModel() {
                username = username,
                realName = realName,
                email = email,
                accessLevel = accessLevel
            });

            CreateUser.FillNewUserInformation(context.GetNewUser());
        }

        [StepDefinition(@"clicar para criar nova conta")]
        public void WhenClicarParaCriarNovaConta()
        {
            var manageUserCreatePage = new ManageUserCreatePage();

            manageUserCreatePage.ClickCreateUser();
        }

    }
}
