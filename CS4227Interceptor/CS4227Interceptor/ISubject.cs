using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal interface ISubject
    {
        public void setMeasurements(float temperature, float humidity, float pressure, Context context);
        public void registerObserver(IObserver o);
        public void unregisterObserver(IObserver o);

        public void notifyObservers();
    }
}
