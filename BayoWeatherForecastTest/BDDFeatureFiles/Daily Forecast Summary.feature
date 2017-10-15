Feature: Daily Forecast Summary
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
  
