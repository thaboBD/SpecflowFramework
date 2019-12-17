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
    }
}
