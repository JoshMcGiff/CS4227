using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class ConcreteInterceptor : IInterceptor
    {
        private int interceptorRequestCount = 0;
        public void Intercept(ISubject element, Context context)
        {
            Console.WriteLine("Interceptor: Attempting display request...");
            element.setMeasurements(Convert.ToSingle(context.Get("TEMPERATURE")), Convert.ToSingle(context.Get("HUMIDITY")), Convert.ToSingle(context.Get("PRESSURE")));
            Console.WriteLine("Interceptor: Display request complete!");
            context.Add("InterceptorRequest" + interceptorRequestCount.ToString(), "Interceptor request made");
            interceptorRequestCount++;
        }
    }
}
