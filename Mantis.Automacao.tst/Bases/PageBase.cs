using Mantis.Automacao.tst.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;

namespace Mantis.Automacao.tst.Bases
{
    class PageBase
    {


        #region Objects and constructor

        protected WebDriverWait wait { get; private set; }
        protected IWebDriver driver { get; private set; }
        protected IJavaScriptExecutor javaScript { get; private set; }

        public PageBase()

        {
            wait = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationSettings.AppSettings["timeout_default"].ToString())));
            driver = DriverFactory.INSTANCE;
            javaScript = (IJavaScriptExecutor)driver;
        }

        #endregion

        #region Custom Actions

        protected IWebElement WaitForElement(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        protected void Click(By locator)

        {
            Stopwatch timeOut = new Stopwatch();
            timeOut.Start();

            while (timeOut.Elapsed.Seconds <= Convert.ToInt32(ConfigurationSettings.AppSettings["timeout_default"].ToString()))
            {
                try
                {
                    WaitForElement(locator).Click();
                    timeOut.Stop();
                    return;
                }
                catch (System.Reflection.TargetInvocationException)
                {
                }

                catch (StaleElementReferenceException)
                {
                }

                catch (System.InvalidOperationException)       
                {
                }

                catch (WebDriverException e)
                {
                    if (e.Message.Contains("Other element would receive the click"))
                    {
                        continue;
                    }
                    if (e.Message.Contains("Element is not clickable at point"))
                    {
                        continue;
                    }              
                    throw e;
                }
            }     

            throw new Exception("Given element isn't visible");
        }

        protected void SendKeys(By locator, string text)
        {
            WaitForElement(locator).SendKeys(text);
        }

        protected void SendKeysWithoutWaitVisible(By locator, string text)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            element.SendKeys(text);
        }

        protected void ComboBoxSelectByVisibleText(By locator, string text)
        {
            OpenQA.Selenium.Support.UI.SelectElement comboBox = new OpenQA.Selenium.Support.UI.SelectElement(WaitForElement(locator));
            comboBox.SelectByText(text);
        }

        protected void MouseOver(By locator)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(WaitForElement(locator)).Build().Perform();
        }

        protected string GetText(By locator)
        {
            string text = WaitForElement(locator).Text;
            return text;
        }

        protected string GetValue(By locator)
        {
            string text = WaitForElement(locator).GetAttribute("value");
            return text;
        }

        protected bool ReturnIfElementIsDisplayed(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Displayed;
            return result;
        }

        protected bool ReturnIfElementIsEnabled(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Enabled;
            return result;
        }

        protected bool ReturnIfElementIsSelected(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Selected;
            return result;

        }

        #endregion

        #region JavaScript Actions

        protected void SendKeysJavaScript(By locator, string value)       
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].value='" + value + "';", element);
        }

        protected void ClickJavaScript(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].click();", element);
        }

        protected void ScrollToElementJavaScript(By locator)
        {
            wait.Until(ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScript.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        protected void ScrollToTop()
        {
            javaScript.ExecuteScript("window.scrollTo(0, 0);");
        }

        #endregion

        #region Default Actions

        public void Refresh()
        {
            DriverFactory.INSTANCE.Navigate().Refresh();
        }

        public void NavigateTo(string url)
        {
            DriverFactory.INSTANCE.Navigate().GoToUrl(url);
        }

        public void OpenNewTab()
        {
            javaScript.ExecuteScript("window.open();");
        }
 
        public void SetFocusToLastTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public void SetFocusToFirstTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public string GetTitle()
        {
            string title = driver.Title;
            return title;
        }

        public string GetURL()
        {
            string url = driver.Url;
            return url;
        }
        #endregion

    }
}