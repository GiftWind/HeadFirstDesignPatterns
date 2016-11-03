using System;

namespace Observer
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

           Console.ReadLine();
        }
    }
}
