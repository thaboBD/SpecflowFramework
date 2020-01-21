using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Selenium.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        
        WebDriverFactory webDriver = new WebDriverFactory();
        private static IWebDriver driver;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static ExtentTest featureName;
        public static ExtentTest scenario;
        public static ExtentReports extent;


        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\tdube\source\repos\Selenium\Selenium\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext f)
        {
            
            featureName = extent.CreateTest<Feature>(f.FeatureInfo.Title);
            
        }


        //Issue with reporting to fix here

        [AfterStep]
        public void InsertReportingSteps(ScenarioContext s)
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (s.TestError != null)
            {
                log.Debug("time to dbugsssss");
            }
            

            if (s.TestError == null)
            {

                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if(s.TestError != null)
            {


                if(stepType =="Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(s.TestError.InnerException);
                        //string path = WebDriverFactory.TakeScreenshot(s.ScenarioInfo.Title);
                        //scenario.AddScreenCaptureFromPath(path);
                       
                else if (stepType ==  "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(s.TestError.InnerException);
                else if (stepType== "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(s.TestError.InnerException);
                        

                
            }
            
        }


        [BeforeScenario]
        public void BeforeScenario(ScenarioContext s)
        {
            WebDriverFactory.InitBrowser("chrome");
            driver = WebDriverFactory.getDriver;
            scenario = featureName.CreateNode<Scenario>(s.ScenarioInfo.Title);


        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext s)
        {
            if (s.TestError != null)
            {
                ScreenshotFactory.TakeScreenshot(s.ScenarioInfo.Title);
            }
            driver.Quit();
        }
    }
}
