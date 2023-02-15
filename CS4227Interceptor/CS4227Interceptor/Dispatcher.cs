using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS4227Interceptor
{
    internal sealed class Dispatcher 
    {
        private static Dispatcher instance = null;


        private static ISubject _element;
        private List<IInterceptor> _interceptors = new List<IInterceptor>();

        public Dispatcher()
        {

        }

        public static void SetUp(ISubject element)
        {
            _element = element;
        }

        public static Dispatcher Instance
        {
            get { 
                if(instance == null)
                {
                    instance = new Dispatcher();
                }
                return instance; 
            }
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


        public void setMeasurements(Context context)
        {
            foreach(IInterceptor interceptor in _interceptors)
            {
                interceptor.Intercept(_element, context);
            }
        }


        public void unregisterObserver(IObserver o)
        {
            throw new NotImplementedException();
        }
    }
}
