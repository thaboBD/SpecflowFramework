using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Selenium.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //Utils.WebDriverFactory DriverFactory = new Utils.WebDriverFactory();
        WebDriverFactory webDriver = new WebDriverFactory();
        private static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverFactory.InitBrowser("firefox");
            // InitBrowser("chrome");
            driver = WebDriverFactory.getDriver;
            

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
