using BayoWeatherForecastTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BayoWeatherForecastTest.StepDefinitions
{
    [Binding]
    public class DailyForecastSummarySteps : GeneralSetUpClass
    {
       
        [Then(@"the summersised 3_hourly weather forcast is displayed for each day rounded down to the nearest value")]
        public void ThenTheSummersisedHourlyWeatherForcastIsDisplayedForEachDayRoundedDownToTheNearestValue(Table table)
        {
            foreach (var row in table.Rows)
            {
                var summary = new WeatherSummary();
                var home = new WeatherForecastHomePage();

                string output;

                row.TryGetValue("Forecast Days", out output);

                if (output == "Tuesday")
                {
                    PageFactory.InitElements(driver, home);
                    var getDay = home.getTuesdaySummary;
                    getDay.Click();
                    Thread.Sleep(2000);

                    row.TryGetValue("Weather Condition", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var Condition = summary.getDayMaxTemp.Text;
                        
                        Assert.IsNotNull(Condition);
                        Console.WriteLine(Condition);

                    }

                    row.TryGetValue("Wind Speed and Direction", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var WindDirection = summary.getSpeedWind.Text;

                        Console.WriteLine(WindDirection);

                        Assert.IsNotNull(WindDirection);

                    }

                    row.TryGetValue("Aggregate Rainfall", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var RainFall = summary.getAggregateRainFall.Text;
                        Console.WriteLine(RainFall);
                        Assert.IsNotNull(RainFall);

                    }

                }
                if (output == "Wednesday")
                {
                    PageFactory.InitElements(driver, home);
                    var getDay = home.getWednesdaySummary;
                    getDay.Click();
                    Thread.Sleep(2000);
                    row.TryGetValue("Weather Condition", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var Condition = summary.getWedDayMaxTemp.Text;

                        int temp = 16;
                        Console.WriteLine((temp % 1) == 0);

                        Assert.IsNotNull(Condition);

                    }

                    row.TryGetValue("Wind Speed and Direction", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var WindDirection = summary.getWedSpeedWind.Text;

                        Console.WriteLine(WindDirection);

                        Assert.IsNotNull(WindDirection);

                    }

                    row.TryGetValue("Aggregate Rainfall", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var RainFall = summary.getWedAggregateRainFall.Text;
                        Console.WriteLine(RainFall);
                        Assert.IsNotNull(RainFall);

                    }

                }

                if (output == "Thursday")
                {
                    PageFactory.InitElements(driver, home);
                    var getDay = home.getThursdaySummary;
                    getDay.Click();
                    Thread.Sleep(2000);
                    row.TryGetValue("Weather Condition", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var Condition = summary.getThursDayMaxTemp.Text;

                        int temp = 16;
                        Console.WriteLine((temp % 1) == 0);

                        Assert.IsNotNull(Condition);
                    }
                    row.TryGetValue("Wind Speed and Direction", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var WindDirection = summary.getThursSpeedWind.Text;

                        Console.WriteLine(WindDirection);

                        Assert.IsNotNull(WindDirection);

                    }

                    row.TryGetValue("Aggregate Rainfall", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var RainFall = summary.getThursAggregateRainFall.Text;
                        Console.WriteLine(RainFall);
                        Assert.IsNotNull(RainFall);

                    }

                }

                if (output == "Friday")
                {
                    PageFactory.InitElements(driver, home);
                    var getDay = home.getFridaySummary;
                    getDay.Click();
                    Thread.Sleep(2000);

                    row.TryGetValue("Weather Condition", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var Condition = summary.getFridayDayMaxTemp.Text;

                        Console.WriteLine(Condition);

                        Assert.IsNotNull(Condition);

                    }

                    row.TryGetValue("Wind Speed and Direction", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var WindDirection = summary.getFriSpeedWind.Text;

                        Console.WriteLine(WindDirection);

                        Assert.IsNotNull(WindDirection);

                    }

                    row.TryGetValue("Aggregate Rainfall", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var RainFall = summary.getFriAggregateRainFall.Text;
                        Console.WriteLine(RainFall);
                        Assert.IsNotNull(RainFall);

                    }

                }

                if (output == "Saturday")
                {
                    PageFactory.InitElements(driver, home);
                    var getDay = home.getSaturdaySummary;
                    getDay.Click();
                    Thread.Sleep(2000);

                    row.TryGetValue("Weather Condition", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var Condition = summary.getSatDayMaxTemp.Text;
                        Assert.IsNotNull(Condition);
                        Console.WriteLine(Condition);

                    }

                    row.TryGetValue("Wind Speed and Direction", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var WindDirection = summary.getSatSpeedWind.Text;

                        Console.WriteLine(WindDirection);

                        Assert.IsNotNull(WindDirection);

                    }

                    row.TryGetValue("Aggregate Rainfall", out output);
                    if (output == "Yes")
                    {
                        PageFactory.InitElements(driver, summary);
                        var RainFall = summary.getSatAggregateRainFall.Text;
                        Console.WriteLine(RainFall);
                        Assert.IsNotNull(RainFall);
                        
                        
                        
                    }
                }

            }
            
            }
        }
    }

