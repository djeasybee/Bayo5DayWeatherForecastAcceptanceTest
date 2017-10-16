using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using OpenQA.Selenium.Chrome;
using BayoWeatherForecastTest.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Threading;

namespace BayoWeatherForecastTest.StepDefinitions
{


    [Binding]
    public class EnterCityNameAndGet5DayWeatherForecastSteps : GeneralSetUpClass
    {
        WeatherForecastHomePage home = new WeatherForecastHomePage();
        static String ForecastPagetitle = "5 Weather Forecast";

        [Given(@"I launch my browser")]
        public void GivenILaunchMyBrowser()
        {
            driver = new ChromeDriver();
           
        }

        [When(@"I enter the local url address")]
        public void WhenIEnterTheLocalUrlAddress()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["applicationUrl"]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }

        [Then(@"I am successfully navigated to the Weather App page")]
        public void ThenIAmSuccessfullyNavigatedToTheWeatherAppPage()
        {
            var PageTile = driver.Title;
            Assert.IsTrue(PageTile.Contains(ForecastPagetitle));
        }


        [Given(@"I am on the (.*) day Weather Forecast homepage")]
        public void GivenIAmOnTheDayWeatherForecasthomepage(int p0)
        {
             driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["applicationUrl"]);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            PageFactory.InitElements(driver, home);
            var NavigateToHomePage = home.getHomepage;
            var Homepage = NavigateToHomePage.Text.ToString();
            Assert.IsTrue(Homepage.Contains("Five Day Weather Forecast"));


        }

      
        [When(@"I enter a city name")]
        public void WhenIEnterACityName(Table table)
        {
            foreach (var row in table.Rows)
            {
                PageFactory.InitElements(driver, home);
                var CityName = home.getCityName;

                string output;

                row.TryGetValue("CityName", out output);

                if (output == "Edinburgh")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getCityName.Clear();
                    home.getCityName.SendKeys("Edinburgh");
                    
                    Actions keyEnter = new Actions(driver);
                    keyEnter.SendKeys(Keys.Enter);

                    Thread.Sleep(2000);
                    var AssertCityName = home.getCityName.GetAttribute("value");
                   Assert.IsTrue(AssertCityName.Contains("Edinburgh"));

                    Thread.Sleep(2000);

                }

                if (output == "Dundee")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getCityName.Clear();
                    home.getCityName.SendKeys("Dundee");

                    Actions keyEnter = new Actions(driver);
                    keyEnter.SendKeys(Keys.Enter);

                    Thread.Sleep(2000);
                    var AssertCityName = home.getCityName.GetAttribute("value");
                    Assert.IsTrue(AssertCityName.Contains("Dundee"));

                    Thread.Sleep(2000);

                }

                if (output == "Dundee")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getCityName.Clear();
                    home.getCityName.SendKeys("Aberdeen");

                    Actions keyEnter = new Actions(driver);
                    keyEnter.SendKeys(Keys.Enter);

                    Thread.Sleep(2000);
                    var AssertCityName = home.getCityName.GetAttribute("value");
                    Assert.IsTrue(AssertCityName.Contains("Aberdeen"));

                    Thread.Sleep(2000);

                }

                if (output == "Glasgow")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getCityName.Clear();
                    home.getCityName.SendKeys("Glasgow");

                    Actions keyEnter = new Actions(driver);
                    keyEnter.SendKeys(Keys.Enter);

                    Thread.Sleep(2000);
                    var AssertCityName = home.getCityName.GetAttribute("value");
                    Assert.IsTrue(AssertCityName.Contains("Glasgow"));

                    Thread.Sleep(2000);

                }
            }
        }


        [Then(@"a 5-days Weather forecast should be for the entered city name '(.*)")]
        public void ThenA_DaysWeatherForecastShouldBeForTheEnteredCityName(string Results)
        {

            {
                Thread.Sleep(2000);

                if (Results == "Forcast displayed" )
                {
                    var enterCityName = home.getCityName;
                    var AssertCityName = home.getCityName.GetAttribute("value");
                    Assert.IsTrue(AssertCityName.Contains(Results));
                }
               
            }


        }
    }
}
