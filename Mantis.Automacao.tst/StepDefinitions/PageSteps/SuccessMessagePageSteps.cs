using Mantis.Automacao.tst.Helpers;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using Mantis.Automacao.tst.Pages;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class SuccessMessagePageSteps
    {
        World context = World.GetInstance();

        [StepDefinition(@"eu tenho a confirmacao de que o usuario foi criado corretamente")]
        public void ThenEuTenhoAConfirmacaoDeQueOUsuarioFoiCriadoCorretamente()
        {
            var successMessagePage = new SuccessMessagePage();

            Assertions.AssertTrue(successMessagePage.AmInUserCreatedSuccessPage(context.GetNewUser().accessLevel));
        }

        [StepDefinition(@"eu devo ver a mensagem de que o projeto foi criado corretamente")]
        public void ThenEuDevoVerAMensagemDeQueOProjetoFoiCriadoCorretamente()
        {
            var successMessagePage = new SuccessMessagePage();

            Assertions.AssertTrue(successMessagePage.AmInOperationSuccessPage());
        }

    }
}
