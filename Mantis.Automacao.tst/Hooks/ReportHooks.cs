using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Mantis.Automacao.tst.Helpers.ReportHelper;
using NUnit.Framework;
using System.Configuration;
using System.IO;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.Hooks
{
    [Binding]
    class ReportHooks
    {
        #region Variables Declaration

        private static ExtentReports extentReports;
        private static ExtentTest extentTest;
        private static ExtentHtmlReporter htmlReporter;
        private static LogTraceListener logTrace = new LogTraceListener();
        private static string ReportingFolderPath = ConfigurationSettings.AppSettings["REPORTING_FOLDER"];
        private static string ReportFilePath = ReportingFolderPath + " " + FeatureContext.Current.FeatureInfo.Title + ".html";

        #endregion

        #region Before Hooks

        [BeforeFeature]
        public static void InitializeReport()
        {
            extentReports = new ExtentReports();

            DirectoryInfo pasta = new DirectoryInfo(ReportingFolderPath);
            if (!pasta.Exists) pasta.Create();

            htmlReporter = new ExtentHtmlReporter(ReportFilePath);
            extentReports.AttachReporter(htmlReporter);

            FeatureContext.Current.Set<ExtentReports>(extentReports);
        }

        [BeforeScenario]
        public static void InitializeReportTest()
        {
            extentTest = FeatureContext.Current.Get<ExtentReports>().CreateTest(ScenarioContext.Current.ScenarioInfo.Title);
            ScenarioContext.Current.Set<ExtentTest>(extentTest);
        }

        [BeforeStep]
        public static void LogCurrentStep()
        {
            logTrace.WriteTestOutput(ScenarioContext.Current.StepContext.StepInfo.Text);
            ScenarioContext.Current.Get<ExtentTest>().Info(LogTraceListener.lastGherkinMessage);
            LogTraceListener.lastGherkinMessage = null;
        }

        #endregion

        #region After Hooks

        [AfterStep]
        public static void LogAfterStep()
        {
            if (LogTraceListener.lastGherkinMessage != null)
                ScenarioContext.Current.Get<ExtentTest>().Info(LogTraceListener.lastGherkinMessage);

            LogTraceListener.lastGherkinMessage = null;
        }

        [AfterScenario]
        public static void WrapUpReport()
        {
            switch (TestContext.CurrentContext.Result.Outcome.Status.ToString().ToLower())
            {
                case "passed":
                    ScenarioContext.Current.Get<ExtentTest>().Pass("Execução do cenário foi bem sucedida");
                    break;
                case "failed":
                    ScenarioContext.Current.Get<ExtentTest>().Fail("Um ou mais erros ocorreram na execução do cenário.");
                    break;
                case "inconclusive":
                    ScenarioContext.Current.Get<ExtentTest>().Warning("Incapaz de determinar o status da execução do cenário");
                    break;
                case "skipped":
                    ScenarioContext.Current.Get<ExtentTest>().Pass("O cenário não foi executado");
                    break;
                default:
                    ScenarioContext.Current.Get<ExtentTest>().Error("Um erro ocorreu ao tentar determinar o status do cenário");
                    break;
            }

            ScenarioContext.Current.Clear();
        }

        [AfterFeature]
        public static void AfterScenario()
        {
            FeatureContext.Current.Get<ExtentReports>().Flush();
            FeatureContext.Current.Clear();
        }

        #endregion
    }
}
