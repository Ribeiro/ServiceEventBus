using ServiceEventBusExample.Message;
using ServiceEventBusExample.MessageBus;
using ServiceEventBusExample.Observable;
using ServiceEventBusExample.Observer;
using ServiceEventBusExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEventBusExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IObservable messageBus = new InternalMessageBus();

            AbstractMessage message = new SaleMessage("Sold 1 20ft container full of cashew nut kernels!!! Yoray!");

            IObserver pushNotificationService = new PushNotificationService();
            IObserver smsNotificationService = new SmsNotificationService();
            IObserver emailNotificationService = new EmailNotificationService();

            messageBus.Subscribe(pushNotificationService);
            messageBus.Subscribe(smsNotificationService);
            messageBus.Subscribe(emailNotificationService);

            messageBus.Notify(message);

            Console.ReadKey();

        }
    }
}
