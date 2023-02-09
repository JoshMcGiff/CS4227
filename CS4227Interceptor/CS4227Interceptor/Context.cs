using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4227Interceptor
{
    internal class Context
    {
        private Dictionary<string, object> _data   = new Dictionary<string, object>();

        public void Add(string key, object value)
        {
            Console.WriteLine(value);
            _data.Add(key, value);
        }

        public object Get(string key)
        {
            return _data[key];  
        }
    }
}
