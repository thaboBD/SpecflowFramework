using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.TestData;
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

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement emailSignin { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement passwordSignin { get; set; }
        

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement loginBtn { get; set; }


        //Methods
        public void signIn()
        {
            Data n = new Data();
            emailSignin.SendKeys(n.Email);
            passwordSignin.SendKeys(n.Password);
            loginBtn.Click();
        }

        public void signIn(string user, string passwrd)
        {
            emailSignin.SendKeys(user);
            passwordSignin.SendKeys(passwrd);
            loginBtn.Click();
        }

        public void enterEmail(String email)
        {
            Random rnd = new Random();
            int num = rnd.Next(10000);
            string userEmail = num + email;
            emailInput.SendKeys(userEmail);

            Data n = new Data();
            n.Email = userEmail;
        }

        public void clickCreateEmail()
        {
            creatEmailBtn.Click();
        }
    }
}
