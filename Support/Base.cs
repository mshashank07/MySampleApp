using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MySampleApp.Support
{
    public abstract class Base
    {
         


        protected RemoteWebDriver Driver
        {
            get { return ScenarioContext.Current.Get<RemoteWebDriver>(); }
            
        }


        public void WaitForPageToLoad()
        {

            var wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(20));
            wait.Until(driver1 => ((IJavaScriptExecutor)Driver).ExecuteScript("return document.readyState").Equals("complete"));

        }


        public String GetTitle()
        {
            return Driver.Title;
        }



    }
}
