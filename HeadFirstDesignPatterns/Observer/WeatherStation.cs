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

            weatherData.SetMeasurements(-2, 85, 756);
            weatherData.SetMeasurements(21, 80, 786);
            weatherData.SetMeasurements(-10, 12, 720);

            Console.ReadLine();
        }
    }
}
