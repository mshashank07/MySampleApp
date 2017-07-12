using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;


namespace MySampleApp
{
    [Binding]
    public class Hooks1
    {
       
        public static RemoteWebDriver Driver = null;


        [BeforeScenario("Initialize")]
        public static void Initialize()
        {
            if (Driver != null) return;
            switch (ConfigurationManager.AppSettings["browser"])
            {

                case "ie":
                    Driver = new InternetExplorerDriver();
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "chrome":
                    Driver = new ChromeDriver();
                    break;

                default:
                    throw new Exception("app.config not set properly");

            }


            Driver.Manage().Window.Maximize();
            ScenarioContext.Current.Set(Driver);
        }



        [AfterScenario("Initialize")]
        public static void AfterScenario()
        {
            if (ScenarioContext.Current.TestError != null) return;
            Driver.Close();
            Driver.Quit();
            Driver = null;
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Close();
            Driver.Quit();
        }

    }
}
