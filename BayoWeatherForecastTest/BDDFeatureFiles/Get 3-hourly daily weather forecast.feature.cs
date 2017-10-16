﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BayoWeatherForecastTest.BDDFeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Get3_HourlyDailyWeatherForecastFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Get 3-hourly daily weather forecast.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Get 3-hourly daily weather forecast", " As a user, \r\n I want to be able select a Day and get houlry forcast for each day" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Get 3-hourly daily weather forecast")))
            {
                global::BayoWeatherForecastTest.BDDFeatureFiles.Get3_HourlyDailyWeatherForecastFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Select day and get the hourly forecast, get 3 hourly forecast")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get 3-hourly daily weather forecast")]
        public virtual void SelectDayAndGetTheHourlyForecastGet3HourlyForecast()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select day and get the hourly forecast, get 3 hourly forecast", ((string[])(null)));
#line 5
  this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given("I am on the 5 day Weather Forecast homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("I enter a city name \'<CityName>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
      testRunner.And("the 5-day Weather forecast is displayed for the city", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
     testRunner.When("I select and click on a displayed Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
     testRunner.Then("the Day should expand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
      testRunner.And("the hourly weather is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Hide the 3-hourly forecast for the Day")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get 3-hourly daily weather forecast")]
        public virtual void HideThe3_HourlyForecastForTheDay()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Hide the 3-hourly forecast for the Day", ((string[])(null)));
#line 14
  this.ScenarioSetup(scenarioInfo);
#line 15
    testRunner.Given("I am on the 5 day Weather Forecast homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
  testRunner.And("I enter a city name \'<CityName>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
     testRunner.And("the 5-day Weather forecast is displayed for the city", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
     testRunner.And("I select and click on a displayed Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
     testRunner.And("the Day should expand", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
     testRunner.When("I click on the again on the Day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
     testRunner.Then("the expanded Day should collapsed and the 3hourly display should be hidden from u" +
                    "ser view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Open the 3 hourly display simutaneously")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get 3-hourly daily weather forecast")]
        public virtual void OpenThe3HourlyDisplaySimutaneously()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open the 3 hourly display simutaneously", ((string[])(null)));
#line 23
  this.ScenarioSetup(scenarioInfo);
#line 24
   testRunner.Given("I am on the 5 day Weather Forecast homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
  testRunner.And("I enter a city name \'<CityName>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
      testRunner.And("I select and click on a day forecast \'<Day>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
      testRunner.And("the \'<Day>\' summary expanded and the 3_hourly weather forcast is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
     testRunner.When("I click on another forecast day \'<Day2>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
     testRunner.Then("the expanded Wednesday weather summary should collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
      testRunner.And("only Thursday should expand and the 3_hourly weather forcast should be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate that the 3 hourly forecast is displayed for each of the five day forecas" +
            "ts")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Get 3-hourly daily weather forecast")]
        public virtual void ValidateThatThe3HourlyForecastIsDisplayedForEachOfTheFiveDayForecasts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate that the 3 hourly forecast is displayed for each of the five day forecas" +
                    "ts", ((string[])(null)));
#line 32
  this.ScenarioSetup(scenarioInfo);
#line 33
    testRunner.Given("I am on the 5 day Weather Forecast homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Forecast Days",
                        "3 hourly display"});
            table1.AddRow(new string[] {
                        "Tuesday",
                        "Yes"});
            table1.AddRow(new string[] {
                        "Wednesday",
                        "Yes"});
            table1.AddRow(new string[] {
                        "Thursday",
                        "Yes"});
            table1.AddRow(new string[] {
                        "Friday",
                        "Yes"});
            table1.AddRow(new string[] {
                        "Saturday",
                        "Yes"});
#line 34
     testRunner.When("I click on each forecast Days and the 3_hrl summary should display", ((string)(null)), table1, "When ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
