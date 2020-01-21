using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObjects
{
    public class CheckOutPage
    {
        private IWebDriver driver;
        private WebDriverWait wt;

        public CheckOutPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']/p[@class='cart_navigation clearfix']/a[1]")]
        public IWebElement proceedToCheckout;

        [FindsBy(How = How.XPath, Using = "//div[@id='ordermsg']/textarea")]
        public IWebElement orderMsg;

        [FindsBy(How = How.XPath, Using = "//p[@class='cart_navigation clearfix']/button")]
        public IWebElement proceedBtn;

        [FindsBy (How = How.Id, Using = "cgv")]
        public IWebElement tcCheckbox;

        [FindsBy(How = How.XPath, Using = "//div[@id='HOOK_PAYMENT']/div[1]/div/p/a")]
        public IWebElement bankTransfer;

        [FindsBy(How = How.XPath, Using = "//p[@id='cart_navigation']/button")]
        public IWebElement confirmOrderBtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']/div/p/strong")]
        public IWebElement confirmationMsg;

        public void clickProceedToCheckout()
        {
            wt = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wt.Until(ExpectedConditions.ElementToBeClickable(proceedToCheckout));
            proceedToCheckout.Click();
        }

        public void typeMsg()
        {
            orderMsg.SendKeys("This dress was ordered using selenium");
        }

        public void proceed()
        {
            wt = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wt.Until(ExpectedConditions.ElementToBeClickable(proceedBtn));
            proceedBtn.Click();
        }

        
        public void tickCheckbox()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(tcCheckbox).Click().Build().Perform();
        }

        public void clickBankTransfer()
        {
            wt = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wt.Until(ExpectedConditions.ElementToBeClickable(bankTransfer));
            bankTransfer.Click();
        }

        public void clickConfirmOrder()
        {
            wt = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wt.Until(ExpectedConditions.ElementToBeClickable(confirmOrderBtn));
            confirmOrderBtn.Click();
        }

        public String getConfirmationMsg()
        {
            return confirmationMsg.Text;
        }

    }
}
