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
            LogRequest(context);
            element.setMeasurements(Convert.ToSingle(context.Get("TEMPERATURE")), Convert.ToSingle(context.Get("HUMIDITY")), Convert.ToSingle(context.Get("PRESSURE")));
            LogResponse(context);
        }

        public void LogRequest(Context context)
        {
            Console.WriteLine("LOGGING Interceptor: Attempting display request with temperature, humidity and pressure of: " + Convert.ToSingle(context.Get("TEMPERATURE")) + "C, " + Convert.ToSingle(context.Get("HUMIDITY")) + " humidity, " + Convert.ToSingle(context.Get("PRESSURE")) + " pressure");
        }

        public void LogResponse(Context context)
        {
            Console.WriteLine("LOGGING Interceptor: Display request complete for: " + Convert.ToSingle(context.Get("TEMPERATURE")) + "C, " + Convert.ToSingle(context.Get("HUMIDITY")) + " humidity, " + Convert.ToSingle(context.Get("PRESSURE")) + " pressure");
            context.Add("InterceptorRequest" + interceptorRequestCount.ToString(), "Interceptor request made");
            interceptorRequestCount++;
        }
    }
}
