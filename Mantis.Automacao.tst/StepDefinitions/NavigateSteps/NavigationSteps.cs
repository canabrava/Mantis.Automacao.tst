﻿using Mantis.Automacao.tst.DBSteps;
using Mantis.Automacao.tst.Flows;
using Mantis.Automacao.tst.Helpers;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.NavigateSteps
{
    [Binding]
    class NavigationSteps
    {
        [StepDefinition(@"entre na tela de criar nova conta")]
        public void GivenEntreNaTelaDeCriarNovaConta()
        {
            Navigation.EnterCreateUserPage();
        }

        [StepDefinition(@"eu entre na tela de criar novo projeto")]
        public void GivenEuEntreNaTelaDeCriarNovoProjeto()
        {
            Navigation.EnterCreateProjectPage();
        }

        [StepDefinition(@"eu entre na tela de gerenciar o projeto '(.*)'")]
        public void GivenEuEntreNaTelaDeGerenciarOProjeto(string nomeProjeto)
        {
            var projectTableDAO = new ProjectTableDAO();

            Navigation.EnterProjectPage(projectTableDAO.ReturnProject(nomeProjeto).id);
        }

        [StepDefinition(@"clicar em voltar")]
        public void WhenClicarEmVoltar()
        {
            DriverFactory.INSTANCE.Navigate().Back();
        }

        [StepDefinition(@"eu entre na tela de gerenciar projetos")]
        public void GivenEuEntreNaTelaDeGerenciarProjetos()
        {
            Navigation.EnterManageProjectsPage();
        }

        [StepDefinition(@"eu entre na tela de criar tarefas")]
        public void GivenEuEntreNaTelaDeCriarTarefas()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
