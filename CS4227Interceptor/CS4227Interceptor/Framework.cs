using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class Framework
    {
        private Dispatcher dispatcher;
        private const string TEMPERATURE = "TEMPERATURE";
        private const string HUMIDITY = "HUMIDITY";
        private const string PRESSURE = "PRESSURE";

        public Framework() {

            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            Dispatcher.SetUp(weatherData);
            dispatcher = new Dispatcher();
            dispatcher.AddInterceptor(new ConcreteInterceptor());


            currentDisplay.display();


        }

        public void SetMeasurements() {
            Context context = new Context();
        
            context.Add(TEMPERATURE, 30);
            context.Add(HUMIDITY, 20);
            context.Add(PRESSURE, 30);
            dispatcher.setMeasurements(context);

            context.Update(TEMPERATURE, 10);
            context.Update(HUMIDITY, 40);
            context.Update(PRESSURE, 80);
            dispatcher.setMeasurements(context);

            context.Update(TEMPERATURE, 100);
            context.Update(HUMIDITY, 25);
            context.Update(PRESSURE, 5);
            dispatcher.setMeasurements(context);
        }
    }
}
