using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium
{
    [Binding]
    public class Class1 : Utils.WebDriverFactory
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static IWebDriver driver = getDriver;
        [Given(@"I am on the automation website")]
        public void GivenIAmOnTheAutomationWebsite()
        {
            
                driver.Url = "http://automationpractice.com";
                log.Info("Navigated to website");
                //log.Info(driver.Title);
               // Assert.AreEqual("My Storex", driver.Title);
                Assert.AreEqual("team", "tom");
                //string path = WebDriverFactory.TakeScreenshot();
                //log.Info(path);
                //WebDriverFactory.TakeScreenshot();

           
               // log.Error("failed test validation");
            

        }

        [When(@"I press sign")]
        public void WhenIPressSign()
        {
            //ScenarioContext.Current.Pending();  
        }

        [When(@"enter my username")]
        public void WhenEnterMyUsername()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"enter my password")]
        public void WhenEnterMyPassword()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"Click Login")]
        public void WhenClickLogin()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the landing page is displayed")]
        public void ThenTheLandingPageIsDisplayed()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
