using ServiceEventBusExample.Message;
using ServiceEventBusExample.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEventBusExample.Observable
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(AbstractMessage message);
    }
}
