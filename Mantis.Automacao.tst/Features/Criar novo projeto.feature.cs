// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mantis.Automacao.tst.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Criar novo projeto")]
    public partial class CriarNovoProjetoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Criar novo projeto.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Criar novo projeto", "\tComo: Administrador\r\n\tQuero: Criar um novo projeto\r\n\tPara: Pessoas trabalharem n" +
                    "ele", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line 9
 testRunner.Given("eu esteja logado como administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Criar um novo projeto")]
        [NUnit.Framework.TestCaseAttribute("projetoTeste", "desenvolvimento", "público", "Projeto para teste do MantisBT", null)]
        [NUnit.Framework.TestCaseAttribute("projetoTeste", "release", "público", "Projeto para teste do MantisBT", null)]
        [NUnit.Framework.TestCaseAttribute("projetoTeste", "estável", "público", "Projeto para teste do MantisBT", null)]
        [NUnit.Framework.TestCaseAttribute("projetoTeste", "obsoleto", "público", "Projeto para teste do MantisBT", null)]
        [NUnit.Framework.TestCaseAttribute("projetoTeste", "desenvolvimento", "privado", "Projeto para teste do MantisBT", null)]
        public virtual void CriarUmNovoProjeto(string nOME_PROJETO, string eSTADO, string vISIBILIDADE, string dESCICAO, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um novo projeto", null, exampleTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 12
 testRunner.And("entre na tela de criar novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.When(string.Format("eu preencher as informacoes do novo projeto: \'{0}\', \'{1}\', \'{2}\', \'<DESCRICAO>\'", nOME_PROJETO, eSTADO, vISIBILIDADE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And("clicar para criar um novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Then("eu devo ver a mensagem de que o projeto foi criado corretamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.And("o novo projeto deve ter sido criado corretamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Criar um novo projeto com nome do projeto repetido")]
        public virtual void CriarUmNovoProjetoComNomeDoProjetoRepetido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um novo projeto com nome do projeto repetido", null, ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
this.FeatureBackground();
#line 27
 testRunner.And("exista um projeto criado com os dados: \'nomeRepetido\', \'desenvolvimento\', \'públic" +
                    "o\', \'Projeto para teste do MantisBT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("entre na tela de criar novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("eu preencher as informacoes do novo projeto: \'nomeRepetido\', \'desenvolvimento\', \'" +
                    "público\', \'Projeto para teste do MantisBT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("clicar para criar um novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("eu devo ver a mensagem de que o projeto nao foi criado corretamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
