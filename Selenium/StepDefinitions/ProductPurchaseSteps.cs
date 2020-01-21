using NUnit.Framework;
using OpenQA.Selenium;
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
    public class ProductPurchaseSteps:Utils.WebDriverFactory
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IWebDriver driver = getDriver;

        [When(@"I search for a dress")]
        public void WhenISearchForADress()
        {
            LandingPage landingPage = new LandingPage(driver);
            landingPage.search("dress");
            log.Info("Product is searched for");

        }

        [When(@"I add it to cart")]
        public void WhenIAddItToCart()
        {
            SearchResultsPage resultsPage = new SearchResultsPage(driver);
            resultsPage.getProducts();
            log.Info("Product is added to cart");
            
            resultsPage.clickProceedToCheckout();
            log.Info("Proceed to checkout button is clicked");
        }

        [Then(@"I can complete the checkout process")]
        public void ThenICanCompleteTheCheckoutProcess()
        {
            CheckOutPage checkOut = new CheckOutPage(driver);
            checkOut.clickProceedToCheckout();
            log.Info("proceed to checkout button is clicked");
            checkOut.typeMsg();
            log.Info("Order message is typed");
            checkOut.proceed();
            log.Info("Proceed to checkout button is clicked");
            checkOut.tickCheckbox();
            log.Info("Terms and conditions textbox is clicked");
            checkOut.proceed();
            log.Info("Proceed to checkout buttn is clicked");
            checkOut.clickBankTransfer();
            log.Info("Bank tranfer is chosen as payment method");
            checkOut.clickConfirmOrder();
            log.Info("Confirm order button is clicked");

            Assert.AreEqual("Your order on My Store is complete.", checkOut.getConfirmationMsg());

        }

    }
}
