using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.PageSteps
{
    [Binding]
    class CreateTaskPageSteps
    {
        [StepDefinition(@"eu entrar com as informações da nova tarefa: '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenEuEntrarComAsInformacoesDaNovaTarefa(string categoria, string frequencia, string gravidade, string prioridade, string atribuirA, string resumo, string descricao, string passosParaReproduzir, string informacoesAdicionais, string visibilidade)
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
