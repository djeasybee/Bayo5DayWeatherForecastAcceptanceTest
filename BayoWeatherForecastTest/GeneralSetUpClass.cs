using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Threading;

namespace BayoWeatherForecastTest
{
    [Binding]
    public class GeneralSetUpClass
    {
        
        public static IWebDriver driver;
        public static IWebDriver Webdriver()
        { 
            if (driver == null)
            {
                driver = new ChromeDriver();
                return driver;

            }
            return driver;
        }

        [AfterScenario]
        public static void DisposeDriver()
        {
            if (driver != null)
            {
                Thread.Sleep(3000);
                driver.Close();
                driver.Dispose();
                driver = null;
            }
        }
        
        

    }
}
