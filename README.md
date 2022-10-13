## Exercise1:
![](https://github.com/Verson-tech/APIs-and-JSON-Exercise/blob/main/k-vs-r.gif)
Let’s create a console application that calls both the Ron Swanson API, and the Kanye West API. Using both APIs, make Ron Swanson and Kanye West have a conversation that prints to the console.

Hints:
Use a for loop to generate at least 5 quotes from each api and have them alternate to simulate a conversation

Here is some code to utilize for parsing the ron swanson response:
```
var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
```

Here are the API urls:

https://ron-swanson-quotes.herokuapp.com/v2/quotes

https://api.kanye.rest


FINISHED Project:
https://github.com/mvdoyle/KanyeAndRonSwanson

## Exercise 2:

Use the [OpenWeatherMap API](https://openweathermap.org/) to find out what the current weather forecast is!

Create an OpenWeatherMap account to get a free API Key

Add the NewtonSoft.Json Nuget Package to your Console App

Figure out how to get the CURRENT weather for the City you specify in degrees fahrenheit

Use this site for extra help:
[https://openweathermap.org/current](https://openweathermap.org/current)

Creatively display & organize the response

Hint: For more info on Units of Measurement visit:
[https://openweathermap.org/current#data](https://openweathermap.org/current#data)
