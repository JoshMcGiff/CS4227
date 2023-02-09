using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class Proxy : ISubject
    {
        private ISubject _element;
        private List<IInterceptor> _interceptors = new List<IInterceptor>();

        public Proxy(ISubject element)
        {
            _element = element;
        }

        public void AddInterceptor(IInterceptor interceptor)
        {
            _interceptors.Add(interceptor);
        }

        public void notifyObservers()
        {
            throw new NotImplementedException();
        }

        public void registerObserver(IObserver o)
        {
            throw new NotImplementedException();
        }

        public void RemoveInterceptor(IInterceptor interceptor)
        {
            _interceptors.Remove(interceptor);
        }


        public void setMeasurements(float temperature, float humidity, float pressure, Context context)
        {
            foreach(IInterceptor interceptor in _interceptors)
            {
                interceptor.Intercept(_element, context, temperature, humidity, pressure);
            }
        }


        public void unregisterObserver(IObserver o)
        {
            throw new NotImplementedException();
        }
    }
}
