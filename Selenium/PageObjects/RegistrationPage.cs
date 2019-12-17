using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObjects
{
   public class RegistrationPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public RegistrationPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement registrationBtn { get; set; }


        [FindsBy(How = How.Id, Using = "id_gender2")]
        public IWebElement genderRadioBtn { get; set; }


        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement firstNameField { get; set; }


        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement lastNameField { get; set; }


        public void typeLName(string lName)
        {
            lastNameField.SendKeys(lName);
        }

        public void typeFName(string fName)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(registrationBtn));
            firstNameField.SendKeys(fName);
        }

        public void clickRegisterBtn()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(registrationBtn));
            registrationBtn.Click();
        }
    }
}

