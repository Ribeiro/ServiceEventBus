using ServiceEventBusExample.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Message;

namespace ServiceEventBusExample.Services
{
    public class EmailNotificationService : IObserver
    {
        public void Receive(AbstractMessage message)
        {
            Console.WriteLine(this.GetType().ToString() + " => Sending Email Notification with content: " + message.GetBody());
        }
    }
}
