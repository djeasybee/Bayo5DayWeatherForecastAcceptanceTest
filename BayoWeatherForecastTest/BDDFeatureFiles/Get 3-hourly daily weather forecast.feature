Feature: Get 3-hourly daily weather forecast
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


  
  