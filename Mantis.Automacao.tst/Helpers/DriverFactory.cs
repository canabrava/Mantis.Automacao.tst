﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;


namespace Mantis.Automacao.tst.Helpers
{
    class DriverFactory
    {
    
        public static IWebDriver INSTANCE { get; set; } = null;
    
        public static void Initialize()
        {
            if (INSTANCE == null)
            {
                string browser = ConfigurationSettings.AppSettings["browser"].ToString();
                string execution = ConfigurationSettings.AppSettings["remote"].ToString().Equals("false") ? "local" : "remota";
                string base_url = ConfigurationSettings.AppSettings["base_url"].ToString();
                string seleniumHub = ConfigurationSettings.AppSettings["seleniumHub"].ToString();
    
                if (INSTANCE == null)
                {
                    switch (browser)
                    {
                        case "chrome":
                            if (execution.Equals("local"))
                            {
                                ChromeOptions chrome = new ChromeOptions();
                                chrome.AddArgument("start-maximized");
                                chrome.AddArgument("enable-automation");
                                chrome.AddArgument("--no-sandbox");
                                chrome.AddArgument("--disable-infobars");
                                chrome.AddArgument("--disable-dev-shm-usage");
                                chrome.AddArgument("--disable-browser-side-navigation");
                                chrome.AddArgument("--disable-gpu");
                                chrome.PageLoadStrategy = PageLoadStrategy.Normal;
                                INSTANCE = new ChromeDriver(chrome);
                            }
                            if (execution.Equals("remota"))
                            {
                                ChromeOptions chrome = new ChromeOptions();
                                chrome.AddArgument("no-sandbox");
                                chrome.AddArgument("--allow-running-insecure-content");                            
                                chrome.AddArgument("--lang=pt-BR");
                                INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), chrome.ToCapabilities());
                            }
                            break;
                        case "ie":
                            if (execution.Equals("local"))
                            {
                                INSTANCE = new InternetExplorerDriver();
                            }
                            if (execution.Equals("remota"))
                            {
                                InternetExplorerOptions ie = new InternetExplorerOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), ie.ToCapabilities());
                            }
                            break;
                        case "firefox":
                            if (execution.Equals("local"))
                            {
                                INSTANCE = new FirefoxDriver();
                            }
                            if (execution.Equals("remota"))
                            {
                                FirefoxOptions firefox = new FirefoxOptions();
                                firefox.SetPreference("intl.accept_languages", "pt-BR");
                                INSTANCE = new RemoteWebDriver(new Uri(seleniumHub), firefox.ToCapabilities());
                            }
                            break;
                        default:
                            throw new Exception("O browser informado não existe ou não é suportado pela automação");
    
                    }
                }
            }
        }
    
        public static void QuitDriver()
        {
            INSTANCE.Quit();
            INSTANCE = null;
        }
    }
    
}
