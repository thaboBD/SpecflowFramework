using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium.StepDefinitions
{
    [Binding]
    public class UserRegistrationSteps: Utils.WebDriverFactory
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static IWebDriver driver = getDriver;

        [Given(@"I am on the automation practice website")]
        public void GivenIAmOnTheAutomationPracticeWebsite()
        {

            driver.Url = "http://automationpractice.com";
            log.Info("Navigated to website");
        }

        [When(@"I click sign and create account")]
        public void WhenIClickSignAndCreateAccount()
        {
            LandingPage landingPage = new LandingPage(driver);
            landingPage.signinBtn.Click();
            log.Info("Signin Button is clicked");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.enterEmail("Thisisatestrun@ww.com");
            loginPage.clickCreateEmail();

           
           

        }
        [When(@"the user enters a firstname")]
        public void WhenTheUserEntersAFirstname()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeFName("TestRun");
            
        }
        
        [When(@"the user enters a last name")]
        public void WhenTheUserEntersALastName()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeLName("Blocke");
        }
        
        [When(@"the user enters a passoword")]
        public void WhenTheUserEntersAPassoword()
        {

        }
        
        [When(@"the user enters an address")]
        public void WhenTheUserEntersAnAddress()
        {

        }
        
        [When(@"the user enters a city")]
        public void WhenTheUserEntersACity()
        {

        }
        
        [When(@"the user enters a postcode")]
        public void WhenTheUserEntersAPostcode()
        {

        }
        
        [When(@"the user enters a phone number")]
        public void WhenTheUserEntersAPhoneNumber()
        {

        }
        
        [Then(@"I can create an account to log in")]
        public void ThenICanCreateAnAccountToLogIn()
        {

            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.clickRegisterBtn();
        }


    }
}
