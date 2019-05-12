using Mantis.Automacao.tst.Helpers;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Mantis.Automacao.tst.Hooks
{
    [Binding]
    class DriverHook : DriverFactory
    {

        [BeforeScenario]
        public void InitializeDriver()
        {
            Initialize();
            INSTANCE.Navigate().GoToUrl(ConfigurationSettings.AppSettings["base_url"]);
        }

        [AfterScenario]
        public void TerminateDriver()
        {
            QuitDriver();
        }

    }
}
