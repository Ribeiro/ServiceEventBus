using ServiceEventBusExample.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceEventBusExample.Observer;

namespace ServiceEventBusExample.Message
{
    public class BaseMessage : AbstractMessage
    {
        private const string BASIC = "BASIC";
        private const string INTEGRATION = "INTEGRATION";
        private const string APPLICATION = "APPLICATION";
        private const string MESSAGE_BUS = "MESSAGE_BUS";

        Dictionary<string, Object> _headers;
        private readonly string _body;

        public BaseMessage(String body)
        {
            this._body = body;
            this._headers = new Dictionary<string, Object>();
        }

        public override string GetBody()
        {
            return this._body;
        }

        private void BuildBasicHeaders()
        {
            this._headers.Add(BASIC, INTEGRATION);
            this._headers.Add(APPLICATION, MESSAGE_BUS);
        }

        public override IReadOnlyDictionary<string, object> GetHeaders()
        {
            IReadOnlyDictionary<string, Object> readOnlyDictionary = this._headers;
            return readOnlyDictionary;
        }

        public override void AddHeader(string key, object value)
        {
            this._headers.Add(key, value);
        }

    }

}
