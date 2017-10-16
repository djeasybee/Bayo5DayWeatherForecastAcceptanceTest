Feature: Enter city name and get 5 day weather forecast
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