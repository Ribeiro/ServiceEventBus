using ServiceEventBusExample.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Observer;

namespace ServiceEventBusExample.Message
{
    public abstract class AbstractMessage
    {
        public abstract string GetBody();

        public abstract IReadOnlyDictionary<string, Object> GetHeaders();

        public abstract void AddHeader(string key, Object value);
    }
}