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
    public class ContactUsPage
    {
        private IWebDriver driver;

        public ContactUsPage(IWebDriver webDriver)
        {
            driver = webDriver;
            PageFactory.InitElements(driver, this);
        }

        //Locators

        [FindsBy(How = How.Id, Using = "id_contact")]
        public IWebElement subjectHeading { get; set; }

        [FindsBy(How = How.Id, Using = "fileUpload")]
        public IWebElement fileUploadForm { get; set; }


        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement msgInputBox { get; set; }

        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement submitMsgBtn { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']/p")]
        public IWebElement confirmationMsg { get; set; }


        public string getConMsg()
        {
            return confirmationMsg.Text.Trim();
        }

        public void clickSubmit()
        {
            submitMsgBtn.Click();
        }

        public void typeMsg()
        {
            msgInputBox.SendKeys("we are testing the system to verify it works");
        }

        public void uploadFile()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\TestData\\sampleFile.txt");
            fileUploadForm.SendKeys(filePath);       
        }


        public void selectHeading()
        {
            SelectElement s = new SelectElement(subjectHeading);
            s.SelectByIndex(1);
        }
    }
}
