﻿using Mantis.Automacao.tst.Flows;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.StepDefinitions.NavigateSteps
{
    [Binding]
    class UserNavigationSteps
    {
        [StepDefinition(@"entre na tela de criar nova conta")]
        public void GivenEntreNaTelaDeCriarNovaConta()
        {
            Navigation.EnterCreateUserPage();
        }

        [StepDefinition(@"entre na tela de criar novo projeto")]
        public void GivenEntreNaTelaDeCriarNovoProjeto()
        {
            Navigation.EnterCreateProjectPage();
        }

    }
}
