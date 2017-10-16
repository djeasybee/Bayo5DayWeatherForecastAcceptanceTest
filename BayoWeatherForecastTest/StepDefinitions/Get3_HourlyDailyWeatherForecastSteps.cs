using BayoWeatherForecastTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BayoWeatherForecastTest.StepDefinitions
{
    [Binding]
    public class Get3_HourlyDailyWeatherForecastSteps:GeneralSetUpClass
    {
        WeatherForecastHomePage home = new WeatherForecastHomePage();
        WeatherForecastHomePage day = new WeatherForecastHomePage();
        
        [Given(@"I enter a city name '(.*)'")]
        public void GivenIEnterACityName(string Edinburgh)
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
        
        [Given(@"the 5-day Weather forecast is displayed for the city")]
        public void GivenThe_DayWeatherForCastIsDisplayedForTheCity()
        {
            var home = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, home);
            var enterCityName = home.getCityName;
            var AssertCityName = home.getCityName.GetAttribute("value");
            Assert.IsTrue(AssertCityName.Contains("Edinburgh"));

            var TueSummary = home.getTuesdaySummary.GetAttribute("class");
            Assert.IsTrue(TueSummary.GetType().IsVisible);
            

            var WedSummary = home.getWednesdaySummary;
            Assert.IsTrue(WedSummary.Displayed);

            var ThurSummary = home.getThursdaySummary;
            Assert.IsTrue(ThurSummary.Displayed);

            var FriSummary = home.getFridaySummary;
            Assert.IsTrue(FriSummary.Displayed);

            var SatSummary = home.getSaturdaySummary;
            Assert.IsTrue(SatSummary.Displayed);
            Thread.Sleep(2000);
        }

        [Given(@"I select and click on a displayed Day")]
        [When(@"I select and click on a displayed Day")]
        public void WhenISelectAndClickOnADisplayedDay()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var day1 = day.getTuesdaySummary;

            day1.Click();
            Thread.Sleep(2000);
        }

        [Given(@"the Day should expand")]
        [Then(@"the Day should expand")]
        public void ThenTheDayShouldExpand()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var TueExpanded = day.getTuesdayExpanded;
            Assert.IsTrue(TueExpanded.Displayed);
            Thread.Sleep(2000);
        }
        
        [Then(@"the hourly weather is displayed")]
        public void ThenTheHourlyWeatherIsDisplayed()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var Tue3hourlyDisplayed = day.getTuesdayExpanded;
            Assert.IsTrue(Tue3hourlyDisplayed.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"I click on the again on the Day")]
        public void WhenIClickOnTheAgainOnTheDay()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var day1 = day.getTuesday;
            day1.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the expanded Day should collapsed and the 3hourly display should be hidden from user view")]
        public void ThenTheExpandedDayShouldCollapsedAndTheHourlyDisplayShouldBeHiddenFromUserView()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var hourlyForecastNotDisplayed = day.getTuesdayExpanded;
            Assert.IsFalse(hourlyForecastNotDisplayed.Displayed);
            Thread.Sleep(2000);
        }

        [Given(@"I select and click on a day forecast '(.*)'")]
        public void GivenISelectAndClickOnADayForecast(string Wednesday)
        {
           var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var day1 = day.getWednesday;
            day1.Click();
            Thread.Sleep(2000);
        }

        [Given(@"the '(.*)' summary expanded and the 3_hourly weather forcast is displayed")]
        public void GivenTheSummaryExpandedAndThe_HourlyWeatherForcastIsDisplayed(string Wednesday)
        {
           var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var Wed3hourlyDisplayed = day.getWednesdayExpanded;
            Assert.IsTrue(Wed3hourlyDisplayed.Displayed);
            Thread.Sleep(2000);
        }

        [When(@"I click on another forecast day '(.*)")]
        public void WhenIClickOnAnotherForecastDay(string Thursday)
        {           
           var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var day2 = day.getThursday;
            day2.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the expanded Wednesday weather summary should collapsed")]
        public void ThenTheExpandedDayShouldCollapsed()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var hourlyForecastNotDisplayed = day.getWednesdayExpanded;
            Assert.IsFalse(hourlyForecastNotDisplayed.Displayed);
            Thread.Sleep(2000);
        }

        [Then(@"only Thursday should expand and the 3_hourly weather forcast should be displayed")]
        public void ThenOnlyThursdayShouldExpandAndTheHourlyWeatherForcastShouldBeDisplayed()
        {
            var day = new WeatherForecastHomePage();
            PageFactory.InitElements(driver, day);
            var hourlyForecastDisplayed = day.getThursdayExpanded;
            Assert.IsTrue(hourlyForecastDisplayed.Displayed);
            Thread.Sleep(2000);
        }
        [When(@"I click on each forecast Days and the 3_hrl summary should display")]
        [Then(@"I click on each forecast Days and the 3_hrl summary should display")]
        public void WhenIClickOnEachForecastDaysAndTheHurlsSummaryShouldDisplay(Table table)
        {
           
            foreach (var row in table.Rows)
            {
                PageFactory.InitElements(driver, home);

                string output;

                row.TryGetValue("Forecast Days", out output);

                if (output == "Tuesday")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getTuesdaySummary.Click();

                    Thread.Sleep(1000);
                    var day = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, day);
                    var hourlyForecastDisplayed = day.getTuesdayExpanded;
                    Assert.IsTrue(hourlyForecastDisplayed.Displayed);
                    Thread.Sleep(2000);

                }

                if (output == "Wednesday")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getWednesdaySummary.Click();

                    Thread.Sleep(1000);
                    var day = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, day);
                    var hourlyForecastDisplayed = day.getWednesdayExpanded;
                    Assert.IsTrue(hourlyForecastDisplayed.Displayed);
                    Thread.Sleep(2000);

                }

                if (output == "Thursday")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getThursdaySummary.Click();

                    Thread.Sleep(1000);
                    var day = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, day);
                    var hourlyForecastDisplayed = day.getThursdayExpanded;
                    Assert.IsTrue(hourlyForecastDisplayed.Displayed);
                    Thread.Sleep(2000);

                }

                if (output == "Friday")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getFridaySummary.Click();

                    Thread.Sleep(1000);
                    var day = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, day);
                    var hourlyForecastDisplayed = day.getFridayExpanded;
                    Assert.IsTrue(hourlyForecastDisplayed.Displayed);
                    Thread.Sleep(2000);


                }

                if (output == "Saturday")
                {
                    var home = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, home);
                    home.getSaturdaySummary.Click();

                    Thread.Sleep(1000);
                    var day = new WeatherForecastHomePage();
                    PageFactory.InitElements(driver, day);
                    var hourlyForecastDisplayed = day.getSaturdayExpanded;
                    Assert.IsTrue(hourlyForecastDisplayed.Displayed);
                    Thread.Sleep(2000);
                }
            }
        }

        [Then(@"the 3_hourly weather forcast for Glasgow should display and visible to user")]
        public void ThenTheHourlyWeatherForcastForGlasgowShouldDisplayAndVisibleToUser(int p0)
        {
            ScenarioContext.Current.Pending();
        }



    }
}
