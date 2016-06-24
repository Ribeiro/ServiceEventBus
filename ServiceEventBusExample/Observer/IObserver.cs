using ServiceEventBusExample.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEventBusExample.Observer
{
    public interface IObserver
    {
        void Receive(AbstractMessage message);
    }
}
