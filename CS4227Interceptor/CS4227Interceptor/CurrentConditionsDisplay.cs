using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class CurrentConditionsDisplay : IObserver
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        private float pressure;
        public CurrentConditionsDisplay(ISubject weatherData) { 
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature  = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "C degrees and " + humidity + "% humidity");
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }
}
