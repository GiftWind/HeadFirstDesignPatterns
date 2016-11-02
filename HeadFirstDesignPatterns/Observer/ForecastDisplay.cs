using System;

namespace Observer
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 768;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (Math.Abs(_currentPressure - _lastPressure) < 1)
            {
                Console.WriteLine("More of the same.");
            }
            else
            {
                Console.WriteLine("Watch out for cooler, rainy weather.");
            }
        }
    }
}
