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
        private IWebDriver driver = getDriver;

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
            landingPage.clickSignin();
            log.Info("Signin Button is clicked");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.enterEmail("Thisisatestrun@ww.com");
            log.Info("Email address is entered");
            loginPage.clickCreateEmail();
        }

        [When(@"the user enters a firstname")]
        public void WhenTheUserEntersAFirstname()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeFName("TestRun");
            log.Info("First name is entered");
        }
        
        [When(@"the user enters a last name")]
        public void WhenTheUserEntersALastName()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeLName("Blocke");
            log.Info("Last name is entered");
        }
        
        [When(@"the user enters a passoword")]
        public void WhenTheUserEntersAPassoword()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typePassword("qwerty44");
            log.Info("Password is entered");
        }
        
        [When(@"the user enters an address")]
        public void WhenTheUserEntersAnAddress()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeAddress("141 the ridgeway street");
            log.Info("Address is entered");
        }
        
        [When(@"the user enters a city")]
        public void WhenTheUserEntersACity()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeCity("Nelson");
            log.Info("City is entered");
        }

        [When(@"the user enters the state")]
        public void WhenTheUserEntersTheState()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.selectState();
            log.Info("state is selected");
        }


        [When(@"the user enters a postcode")]
        public void WhenTheUserEntersAPostcode()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typePostcode("70113");
            log.Info("Postcode is entered");
        }
        
        [When(@"the user enters a phone number")]
        public void WhenTheUserEntersAPhoneNumber()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.typeMobile("022665565");
            log.Info("Mobile number is entered");
        }

        [Then(@"I can create an account to log in")]
        public void ThenICanCreateAnAccountToLogIn()
        {

            RegistrationPage regPage = new RegistrationPage(driver);
            regPage.clickRegisterBtn();
            log.Info("Registration button is clicked");

            LandingPage landingPage = new LandingPage(driver);
            landingPage.clickSignout();
            log.Info("Signout button is clicked");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.signIn();
            log.Info("Succesfully signed in");

        }
    }
}
