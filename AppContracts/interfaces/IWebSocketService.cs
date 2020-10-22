using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace AppContracts.interfaces
{
    public interface IWebSocketService
    {
        public void Add(string docID, string userID, WebSocket socket);

        public Task SendToAllLesteners(string marker, string docId);
    }
}
