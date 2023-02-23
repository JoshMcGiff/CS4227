using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    public class Framework
    {
        private Dispatcher dispatcher;
        private const string TEMPERATURE = "TEMPERATURE";
        private const string HUMIDITY = "HUMIDITY";
        private const string PRESSURE = "PRESSURE";
        private CurrentConditionsDisplay currentDisplay;

        public Framework() {

            WeatherData weatherData = new WeatherData();

            currentDisplay = new CurrentConditionsDisplay(weatherData);

            Dispatcher.SetUp(weatherData);
            dispatcher = new Dispatcher();
            dispatcher.AddInterceptor(new ConcreteInterceptor());


            currentDisplay.display();


        }

        public void SetMeasurements(float temperature, float humidity, float pressure) {
            Context context = new Context();
        
            context.Add(TEMPERATURE, temperature);
            context.Add(HUMIDITY, humidity);
            context.Add(PRESSURE, pressure);
            dispatcher.setMeasurements(context);

        }

        public void GetTempFahrenheit(float temperature)
        {
            Context context = new Context();

            context.Add(TEMPERATURE, temperature);
            dispatcher.getAvgTempFahrenheit(context);
        }

        public float GetTemperature()
        {
            return currentDisplay.GetTemperature();
        }

        public float GetHumidity()
        {
            return currentDisplay.GetHumidity();
        }

        public float GetPressure()
        {
            return currentDisplay.GetPressure();
        }
    }
}
