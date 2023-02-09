using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal interface IInterceptor
    {
        void Intercept(ISubject element, Context context, float temperature, float humidity, float pressure);
    }
}
