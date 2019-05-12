using AventStack.ExtentReports;
using Mantis.Automacao.tst.Models;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Helpers.ReportHelper
{
    class Assertions
    {
        private static IWebDriver driver = DriverFactory.INSTANCE;
        private static ExtentTest extentTest;

        public static void AssertTrue(ResultModel result)
        {
            try
            {
                Assert.True(result.result);
                extentTest.Pass(result.message);
            }
            catch (AssertionException)
            {
                extentTest.Fail(result.message, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(driver)).Build());
            }
        }

        public static void AssertFalse(ResultModel result)
        {
            try
            {
                Assert.False(result.result);
                extentTest.Pass(result.message);
            }
            catch (AssertionException)
            {
                extentTest.Fail(result.message, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(driver)).Build());
            }
        }
    }
}
