using NUnit.Framework;
using OpenQA.Selenium;
using Selenium.PageObjects;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Selenium.StepDefinitions
{
    [Binding]
    public class ContactUsSteps:WebDriverFactory
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static IWebDriver driver = getDriver;


        [Given(@"I have signed in on the website")]
        public void GivenIHaveSignedInOnTheWebsite()
        {
            driver.Url = "http://automationpractice.com";
            log.Info("Navigated to website");

            LandingPage landingPage = new LandingPage(driver);
            landingPage.clickSignin();
            log.Info("Sign in button is clicked");

            LoginPage loginPage = new LoginPage(driver);
            loginPage.signIn("3910Thisisatestrun@ww.com","qwerty44");
            log.Info("Succesfully signed in");


            
        }

        [When(@"I navigate to the contact us page")]
        public void WhenINavigateToTheContactUsPage()
        {
            LandingPage landing = new LandingPage(driver);
            landing.clickContactUs();
            log.Info("Clicked on contact us");
        }

        [When(@"select a heading")]
        public void WhenSelectAHeading()
        {
            ContactUsPage contactPage = new ContactUsPage(driver);
            contactPage.selectHeading();
            log.Info("heading is selected");
        }

        [When(@"Select an order Ref")]
        public void WhenSelectAnOrderRef()
        {
            
        }

        [When(@"attach a file")]
        public void WhenAttachAFile()
        {
            ContactUsPage contactPage = new ContactUsPage(driver);
            contactPage.uploadFile();
            log.Info("File is uploaded");

        }

        [Then(@"the message is sent")]
        public void ThenTheMessageIsSent()
        {
            ContactUsPage contactPage = new ContactUsPage(driver);
            contactPage.typeMsg();
            log.Info("Message is typed");
            contactPage.clickSubmit();
            log.Info("Message is submited");

            Assert.AreEqual("Your message has been successfully sent to our team.", contactPage.getConMsg());
        }

    }
}
