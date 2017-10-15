using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayoWeatherForecastTest.PageObjects
{
    public class WeatherSummary
    {
        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(2) > div.summary > span:nth-child(2) > svg")]
        public IWebElement getTuesdayDominantWeather{get; set;}

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3) > div.summary > span:nth-child(2) > svg")]
        public IWebElement getWednesdayDominantWeather { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4) > div.summary > span:nth-child(2) > svg")]
        public IWebElement getThursdayDominantWeather { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5) > div.summary > span:nth-child(2) > svg")]
        public IWebElement getFridayDominantWeather { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6) > div.summary > span:nth-child(2) > svg")]
        public IWebElement getSaturdayDominantWeather { get; set; }

        [FindsBy(How =How.CssSelector,Using = "#root > div > div:nth-child(2) > div.summary > span:nth-child(3) > span.max")]
        public IWebElement getDayMaxTemp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3) > div.summary > span:nth-child(3) > span.max")]
        public IWebElement getWedDayMaxTemp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4) > div.summary > span:nth-child(3) > span.max")]
        public IWebElement getThursDayMaxTemp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5) > div.summary > span:nth-child(3) > span.max")]
        public IWebElement getFridayDayMaxTemp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6) > div.summary > span:nth-child(3) > span.max")]
        public IWebElement getSatDayMaxTemp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(2) > div.summary > span:nth-child(4) > span.speed")]
        public IWebElement getSpeedWind { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3) > div.summary > span:nth-child(4) > span.speed")]
        public IWebElement getWedSpeedWind { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4) > div.summary > span:nth-child(4) > span.speed")]
        public IWebElement getThursSpeedWind { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5) > div.summary > span:nth-child(4) > span.speed")]
        public IWebElement getFriSpeedWind { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6) > div.summary > span:nth-child(4) > span.speed")]
        public IWebElement getSatSpeedWind { get; set; }


        [FindsBy(How =How.CssSelector,Using = "#root > div > div:nth-child(2) > div.summary > span:nth-child(5) > span.rainfall")]
        public IWebElement getAggregateRainFall { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3) > div.summary > span:nth-child(5) > span.rainfall")]
        public IWebElement getWedAggregateRainFall { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4) > div.summary > span:nth-child(5) > span.rainfall")]
        public IWebElement getThursAggregateRainFall { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5) > div.summary > span:nth-child(5) > span.rainfall")]
        public IWebElement getFriAggregateRainFall { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6) > div.summary > span:nth-child(5) > span.rainfall")]
        public IWebElement getSatAggregateRainFall { get; set; }
    }
}
