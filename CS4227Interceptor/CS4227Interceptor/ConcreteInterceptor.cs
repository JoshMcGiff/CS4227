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
        public void Intercept(ISubject element, Context context, float temperature, float humidity, float pressure)
        {
            Console.WriteLine("Interceptor: Attempting display request...");
            element.setMeasurements(temperature, humidity, pressure, context);
            Console.WriteLine("Interceptor: Display request complete!");
            context.Add("InterceptorRequest" + interceptorRequestCount.ToString(), "Interceptor request made");
            interceptorRequestCount++;
        }
    }
}
