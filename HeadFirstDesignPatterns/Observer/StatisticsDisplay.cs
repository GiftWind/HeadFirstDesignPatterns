﻿using System;

namespace Observer
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _maxTemp = 0;
        private float _minTemp = 40;
        private float _tempSum = 0;
        private int _numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _tempSum += temperature;
            _numReadings++;

            if (temperature > _maxTemp)
            {
                _maxTemp = temperature;
            }

            if (temperature < _minTemp)
            {
                _minTemp = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numReadings}/{_maxTemp}/{_minTemp}");
        }
    }
}
