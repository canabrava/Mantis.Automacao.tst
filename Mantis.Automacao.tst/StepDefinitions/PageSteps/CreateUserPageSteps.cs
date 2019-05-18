using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Models;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class CreateUserPageSteps
    {
        World context = World.GetInstance();

        [StepDefinition(@"eu preencher as informacoes do novo usuario: '(.*)', '(.*)', '(.*)' e (.*)")]
        public void WhenEuPreencherAsInformacoesDoNovoUsuarioE(string username, string realName, string email, string accessLevel)
        {
            context.SetUser(new UserModel()
            {
                username = username,
                realName = realName,
                email = email,
                accessLevel = accessLevel
            });

            CreateUser.FillNewUserInformation(context.GetUser());
        }

        [StepDefinition(@"clicar para criar nova conta")]
        public void WhenClicarParaCriarNovaConta()
        {
            var manageUserCreatePage = new CreateUserPage();

            manageUserCreatePage.ClickCreateUser();
        }

    }
}
