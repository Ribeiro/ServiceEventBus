using ServiceEventBusExample.Message;
using ServiceEventBusExample.Observable;
using ServiceEventBusExample.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Observer;

namespace ServiceEventBusExample.MessageBus
{
    public class InternalMessageBus : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Notify(AbstractMessage message)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Receive(message);
            }
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
