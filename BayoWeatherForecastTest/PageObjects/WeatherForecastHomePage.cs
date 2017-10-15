using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayoWeatherForecastTest.PageObjects
{
    public class WeatherForecastHomePage:GeneralSetUpClass
    {
        [FindsBy(How =How.CssSelector,Using = "body")]
        public IWebElement getHomepage { get; set; }

        [FindsBy(How =How.CssSelector, Using= "#city")]
        public IWebElement getCityName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(2) > div.summary > span:nth-child(1) > span.name")]
        public IWebElement getTuesday { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3)")]
        public IWebElement getWednesday { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4)")]
        public IWebElement getThursday { get; set; }

        [FindsBy(How = How.TagName, Using = "Fri")]
        public IWebElement getFriday { get; set; }

        [FindsBy(How = How.TagName, Using = "Sat")]
        public IWebElement getSaturday { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(2)")]
        public IWebElement getTuesdaySummary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3)")]
        public IWebElement getWednesdaySummary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4)")]
        public IWebElement getThursdaySummary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5)")]
        public IWebElement getFridaySummary { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6)")]
        public IWebElement getSaturdaySummary { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(2) > div.details")]
        public IWebElement getTuesdayExpanded { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(3) > div.details")]
        public IWebElement getWednesdayExpanded { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(4) > div.details")]
        public IWebElement getThursdayExpanded { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(5) > div.details")]
        public IWebElement getFridayExpanded { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#root > div > div:nth-child(6) > div.details")]
        public IWebElement getSaturdayExpanded { get; set; }

      
    }
}
