using ServiceEventBusExample.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Observer;

namespace ServiceEventBusExample.Message
{
    public class SaleMessage : BaseMessage
    {
        public SaleMessage(string body) : base(body)
        {

        }
    }
}
