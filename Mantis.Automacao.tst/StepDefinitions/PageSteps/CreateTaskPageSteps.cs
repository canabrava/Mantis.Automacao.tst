using System.Data;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class CreateTaskPageSteps
    {

        [When(@"eu entrar com as informações da nova tarefa com as informações:")]
        public void WhenEuEntrarComAsInformacoesDaNovaTarefaComAsInformacoes(DataTable table)
        {
            ScenarioContext.Current.Pending();
        }


        [StepDefinition(@"clicar para criar uma nova tarefa")]
        public void WhenClicarParaCriarUmaNovaTarefa()
        {
            ScenarioContext.Current.Pending();
        }

        [StepDefinition(@"eu marco a opção de criar mais tarefas")]
        public void WhenEuMarcoAOpcaoDeCriarMaisTarefas()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
