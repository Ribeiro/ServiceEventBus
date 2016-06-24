using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Message;
using ServiceEventBusExample.Observer;

namespace ServiceEventBusExample.Services
{
    public class PushNotificationService : IObserver
    {
        public void Receive(AbstractMessage message)
        {
            Console.WriteLine(this.GetType().ToString() + " => Sending Push Notification with content: " + message.GetBody());
        }
    }
}
