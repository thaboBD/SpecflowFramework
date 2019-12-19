using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObjects
{
    public class LandingPage
    {

        private IWebDriver driver;

        public LandingPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//nav/div[1]/a")]
        public IWebElement signinBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//nav/div[2]/a")]
        public IWebElement signoutBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[@id='contact-link']/a")]
        public IWebElement contactUsBtn { get; set; }

        public void clickSignin()
        {
            signinBtn.Click();
        }

        public void clickContactUs()
        {
            contactUsBtn.Click();
        }


        public void clickSignout()
        {
            signoutBtn.Click();
        }
    }

   
}
