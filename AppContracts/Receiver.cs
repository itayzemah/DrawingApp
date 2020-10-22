using AppContracts.interfaces;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppContracts
{
    public class Receiver : IReceiver
    {
       
        public Receiver(string userID, WebSocket webSocket)
        {
            this.UserID = userID;
            this.Socket = webSocket;
        }
        

    }
}
