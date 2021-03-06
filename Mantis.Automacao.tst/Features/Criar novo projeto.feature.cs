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
    [TechTalk.SpecRun.FeatureAttribute("Criar novo projeto", new string[] {
            "Projetos"}, Description="\tComo: Administrador\r\n\tQuero: Criar um novo projeto\r\n\tPara que:: Pessoas trabalha" +
        "rem nele", SourceFile="Features\\Criar novo projeto.feature", SourceLine=1)]
    public partial class CriarNovoProjetoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Criar novo projeto.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Criar novo projeto", "\tComo: Administrador\r\n\tQuero: Criar um novo projeto\r\n\tPara que:: Pessoas trabalha" +
                    "rem nele", ProgrammingLanguage.CSharp, new string[] {
                        "Projetos"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
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
#line 9
#line 10
 testRunner.Given("eu esteja logado como administrador", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void CriarUmNovoProjeto(string nOME_PROJETO, string eSTADO, string vISIBILIDADE, string dESCICAO, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um novo projeto", null, exampleTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 13
 testRunner.And("eu entre na tela de criar novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When(string.Format("eu preencher as informacoes do novo projeto: \'{0}\', \'{1}\', \'{2}\', \'<DESCRICAO>\'", nOME_PROJETO, eSTADO, vISIBILIDADE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("clicar para criar um novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("eu devo ver a mensagem de que o projeto foi criado corretamente", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("o projeto deve estar salvo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto, Variant 0", SourceLine=20)]
        public virtual void CriarUmNovoProjeto_Variant0()
        {
#line 12
this.CriarUmNovoProjeto("projetoTeste", "desenvolvimento", "público", "Projeto para teste do MantisBT", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto, Variant 1", SourceLine=20)]
        public virtual void CriarUmNovoProjeto_Variant1()
        {
#line 12
this.CriarUmNovoProjeto("projetoTeste", "release", "público", "Projeto para teste do MantisBT", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto, Variant 2", SourceLine=20)]
        public virtual void CriarUmNovoProjeto_Variant2()
        {
#line 12
this.CriarUmNovoProjeto("projetoTeste", "estável", "público", "Projeto para teste do MantisBT", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto, Variant 3", SourceLine=20)]
        public virtual void CriarUmNovoProjeto_Variant3()
        {
#line 12
this.CriarUmNovoProjeto("projetoTeste", "obsoleto", "público", "Projeto para teste do MantisBT", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto, Variant 4", SourceLine=20)]
        public virtual void CriarUmNovoProjeto_Variant4()
        {
#line 12
this.CriarUmNovoProjeto("projetoTeste", "desenvolvimento", "privado", "Projeto para teste do MantisBT", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Criar um novo projeto com nome do projeto repetido", SourceLine=26)]
        public virtual void CriarUmNovoProjetoComNomeDoProjetoRepetido()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Criar um novo projeto com nome do projeto repetido", null, ((string[])(null)));
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
this.FeatureBackground();
#line 28
 testRunner.And("exista um projeto criado com os dados: \'nomeRepetido\', \'desenvolvimento\', \'públic" +
                    "o\', \'Projeto para teste do MantisBT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("eu entre na tela de criar novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("eu preencher as informacoes do novo projeto: \'nomeRepetido\', \'desenvolvimento\', \'" +
                    "público\', \'Projeto para teste do MantisBT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("clicar para criar um novo projeto", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("eu devo ver a mensagem de que já existe um projeto com esse nome", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
