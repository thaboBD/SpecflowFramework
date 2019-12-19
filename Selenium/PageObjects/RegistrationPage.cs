using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenium.TestData;
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

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordField { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement address1 { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement city { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement postcode { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement mobile { get; set; }


        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement state { get; set; }

        public void selectState()
        {
            SelectElement s = new SelectElement(state);
            s.SelectByIndex(6);
        }

        public void typeMobile(string number)
        {
            mobile.SendKeys(number);
        }

        public void typePostcode(string zipCode)
        {
            postcode.SendKeys(zipCode);
        }

        public void typeCity(string citytxt)
        {
            city.SendKeys(citytxt);
        }

        public void typeAddress(string add)
        {
            address1.SendKeys(add);
        }

        public void typePassword(string pword)
        {
            Data n = new Data();
            n.Password = pword;
            passwordField.SendKeys(pword);
        }

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

