using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Utils
{
   public class ScreenshotFactory:WebDriverFactory
    {
        private static IWebDriver driver = getDriver;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static string TakeScreenshot(string name)
        {
            string path = null;
            try
            {
                DateTime now = DateTime.Now;
                string path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                path = path1 + "Screenshot\\" + name + now.ToString("yyyyMMMMdd HH,mm,ss") + ".png";
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);

            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            return path;

        }
    }
}
