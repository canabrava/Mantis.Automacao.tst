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
        SuccessMessagePage successMessagePage = new SuccessMessagePage();

        [StepDefinition(@"eu tenho a confirmacao de que o usuario foi criado corretamente")]
        public void ThenEuTenhoAConfirmacaoDeQueOUsuarioFoiCriadoCorretamente()
        {
            Assertions.AssertTrue(successMessagePage.AmInUserCreatedSuccessPage(context.GetUser().accessLevel));
        }

        [StepDefinition(@"eu devo ver a mensagem de que o projeto foi criado corretamente")]
        public void ThenEuDevoVerAMensagemDeQueOProjetoFoiCriadoCorretamente()
        {
            Assertions.AssertTrue(successMessagePage.AmInOperationSuccessPage());
        }

        [StepDefinition(@"o sistema deve mostra a tela confirmando a criação da tarefa")]
        public void ThenOSistemaDeveMostraATelaConfirmandoACriacaoDaTarefa()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"o sistema deve exibir a opção de criar mais tarefas")]
        public void ThenOSistemaDeveExibirAOpcaoDeCriarMaisTarefas()
        {
            //TODO: Confirmar em qual página esse passo fica melhor
            ScenarioContext.Current.Pending();
        }


    }
}
