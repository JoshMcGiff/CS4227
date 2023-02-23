using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers= new List<IObserver>(); 
        }


        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i != -1)
            {
                observers.RemoveAt(i);
            }
        }

        public void notifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature= temperature;
            this.humidity= humidity;
            this.pressure= pressure;
            measurementsChanged();
        }

        public static float CalcAvgTempFahrenheit(float temperature)
        {
            return (temperature * 1.8f) + 32;
        }
    }
}
