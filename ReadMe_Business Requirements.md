 Requirement: Enter city name and get 5 day weather forecast
Feature 1: Enter city name and get 5 day weather forecast
 
As a user, after I install the Weather App locally on my device
I want to be able navigate to the Weather App page on my browser
So that I can see a 5 day Weather Forecast for my choosen city 


Scenario: Navigate to the Weather App home page
    Given I launch my browser  
     When I enter the local url address
     Then I am successfully navigated to the Weather App page

Scenario: Enter city name get 5 day weather forecast
    Given I am on the 5 day Weather Forecast homepage
     When I enter a city name 

	 | CityName  | Results            |
	 | Edinburgh | Forcast displayed  |
	 | Dundee    | Forecast displayed |
	 | Glasgow   | Forecast displayed |
	 | Aberdeen  |Forecast displayed  |

Then a 5-days Weather forecast should be for the entered city name '<Results>

The aim of the above test is to validate that the Weather App is sucessfully launched, 
And the user can submit simple query request to view 5_day weather forecast for input city.

During the Test, I observed that the city input field is not clearly defined, 
and as such, it might not be clear to the user that the text field is editable for inputs.

Whilst I have carried out an exploratory test of the application,
I would have perform a negative-test, to assert the result of an unknown city or incomplete city name, 
and validate that an appropriate error warning is displayed to the user

***************************************************************************************************************
 Requirement: Get 3-hourly daily weather forecast

Feature 2: Get 3-hourly daily weather forecast

 As a user, 
 I want to be able select a Day and get houlry forcast for each day
   
  Scenario: Select day and get the hourly forecast, get 3 hourly forecast
    Given I am on the 5 day Weather Forecast homepage
     And I enter a city name '<CityName>'
     And the 5-day Weather forecast is displayed for the city
     When I select and click on a displayed Day
     Then the Day should expand 
      And the hourly weather is displayed
  
 
  Scenario: Hide the 3-hourly forecast for the Day
    Given I am on the 5 day Weather Forecast homepage
    And I enter a city name '<CityName>'
     And the 5-day Weather forecast is displayed for the city
     And I select and click on a displayed Day
     And the Day should expand 
     When I click on the again on the Day 
     Then the expanded Day should collapsed and the 3hourly display should be hidden from user view 
  
  Scenario: Open the 3 hourly display simutaneously
     Given I am on the 5 day Weather Forecast homepage
     And I enter a city name '<CityName>'
     And I select and click on a day forecast '<Day>' 
     And the '<Day>' summary expanded and the 3_hourly weather forcast is displayed
     When I click on another forecast day '<Day2>
     Then the expanded Wednesday weather summary should collapsed
     And only Thursday should expand and the 3_hourly weather forcast should be displayed
  
  Scenario: Validate that the 3 hourly forecast is displayed for each of the five day forecasts
    Given I am on the 5 day Weather Forecast homepage
     When I click on each forecast Days and the 3_hrl summary should display
     
      | Forecast Days | 3 hourly display | 
      | Tuesday       | Yes              | 
      | Wednesday     | Yes              | 
      | Thursday      | Yes              | 
      | Friday        | Yes              | 
      | Saturday      | Yes              | 

The aim of the above Scenario Tests are to validate that a 3-hourly Weathar forcast is displayed to the user,
when clicked on any of the display days. The select day table should expand to expose the 3-hourly weather forcast
to the user and closed(hide) when day or any other display day is clicked.

Whilst I have carried out an exploratory test of the application using a Chrome browser, 
if given more time, I would have perform a multi browser test in order to validate that application performs as
expected across other browsers. 
During my expolratory test, I observed that application GUI is not intractive on a microsoft window Edge broswer, 
as such the application might not perform as expected on other portable Window explorer devices.
 
*******************************************************************************************************************
Requirement: Get 3-hourly daily weather forecast


Feature 3: Daily Forecast Summary
  As a User
  I want the Daily weather forecast to summarise and display the accumulated 3 hourly forecast for each day 
  in the following data groups;
  1. The most dominant (or current) condition of the day for city
  2. The most dominant (or current) wind speed and direction
  3. Aggregate rainfall of the day for city
  4. Minimum and maximum temperatures of the day for city
  So that I can see the rounded down values for each weather summeries.
  
  Scenario: Validate the accumulated 3 hourly weather condition forecast summary is displayed for each day
    Given I am on the 5 day Weather Forecast homepage
     Then the summersised 3_hourly weather forcast is displayed for each day rounded down to the nearest value
    
      | Forecast Days | Weather Condition | Wind Speed and Direction | Aggregate Rainfall | Results                                          | 
      | Tuesday       | Yes               | Yes                      | Yes                | Summary value Rounded down to the nearest value  | 
      | Wednesday     | Yes               | Yes                      | Yes                | Summary value Rounded down to the nearest value  | 
      | Thursday      | Yes               | Yes                      | Yes                | Summary value Rounded down to the nearest value  | 
      | Friday        | Yes               | Yes                      | Yes                | Summary value Rounded down to the nearest value  | 
      | Saturday      | Yes               | Yes                      | Yes                | Summary value Rounded down to the nearest value  | 
  


The aim of the above scenario test is to validate and assert that the 5-day weather forecast page displays a summart of the weather for each of the five day.
Validation that the summary of the Dominant or current weather condition is displayed on daily summary and visible to the user
Validation that the summary of the Dominant or current Wind Speed is displayed on daily daily summary and visible to the user
Validation that the Aggregate rainfall of the day for city displayed on the daily summary and visible to the user
Validation that the Minimum and maximum temperatures of the day for city on the daily summary and visible to the user

If given time , I would have carried out a validation test that the given weather summary are correct,
 a validation of the GUI output on the database.