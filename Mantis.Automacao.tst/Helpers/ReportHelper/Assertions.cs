using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Mantis.Automacao.tst.Helpers.ReportHelper
{
    class Assertions
    {
        private static IWebDriver driver = DriverFactory.INSTANCE;
        private static ExtentTest extentTest;

        public static void AssertTrue(bool assertedValue, string failingMessage, string passingMessage)
        {
            try
            {
                Assert.IsTrue(assertedValue, failingMessage);
                extentTest.Pass(passingMessage);
            }
            catch (AssertionException)
            {
                extentTest.Fail(failingMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(driver)).Build());
            }
        }

        public static void AssertFalse(IWebDriver driver, ExtentTest extentTest, bool assertedValue, string failingMessage, string passingMessage)
        {
            try
            {
                Assert.IsFalse(assertedValue, failingMessage);
                extentTest.Pass(passingMessage);
            }
            catch (AssertionException)
            {
                extentTest.Fail(failingMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(driver)).Build());
            }
        }

        public static void AssertEquals(IWebDriver driver, ExtentTest extentTest, object actualValue, object expectedValue, string failingMessage, string passingMessage)
        {
            try
            {
                Assert.AreEqual(expectedValue, actualValue, failingMessage);
                extentTest.Pass(passingMessage);
            }
            catch (AssertionException)
            {
                extentTest.Fail(failingMessage, MediaEntityBuilder.CreateScreenCaptureFromPath(ReportingHelper.CreateScreenshot(driver)).Build());
            }
        }
    }
}
