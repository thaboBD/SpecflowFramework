using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObjects
{
    public class SearchResultsPage
    {
        private IWebDriver driver;
        private WebDriverWait wt;


        List<IWebElement> products = new List<IWebElement>();

        public SearchResultsPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']/ul")]
        public IWebElement productList;

        [FindsBy(How = How.XPath, Using = "//div[@id='layer_cart']/div[@class='clearfix']/div[@class='layer_cart_cart col-xs-12 col-md-6']/div[@class='button-container']/a")]
        public IWebElement proceedToCheckoutBtn;

        //Getting products and adding them to a list before addding to cart
        public void getProducts()
        {
            products = productList.FindElements(By.TagName("li")).ToList();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", products[2]);

            //Hover over element and click on it
            Actions hover = new Actions(driver);
            hover.MoveToElement(products[2]).Perform();
            products[2].FindElement(By.XPath("//a[@class='button ajax_add_to_cart_button btn btn-default']/span")).Click();
        }

        public void clickProceedToCheckout()
        {
            wt = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            wt.Until(ExpectedConditions.ElementToBeClickable(proceedToCheckoutBtn));
            proceedToCheckoutBtn.Click();
        }
        
        
    }
}
