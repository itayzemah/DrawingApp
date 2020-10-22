using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace AppContracts.interfaces
{
    public class IReceiver
    {
        public string UserID { get; set; }
        public WebSocket Socket { get; set; }
    }
}
