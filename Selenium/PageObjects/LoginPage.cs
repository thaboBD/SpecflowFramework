using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObjects
{
   public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }


        //Webelement locators
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement emailInput { get; set; }

        
        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        public IWebElement creatEmailBtn { get; set; }


        //Methods
        public void enterEmail(String email)
        {
            emailInput.SendKeys(email);
        }

        public void clickCreateEmail()
        {
            creatEmailBtn.Click();
        }
    }
}
