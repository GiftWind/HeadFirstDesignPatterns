using System;

namespace Observer
{
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            
            CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(22, 70, 30);
            weatherData.SetMeasurements(21, 80, 80);
            weatherData.SetMeasurements(-5, 12, 22);

            Console.ReadLine();
        }
    }
}
