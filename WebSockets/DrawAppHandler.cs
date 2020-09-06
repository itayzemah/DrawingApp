using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace WebSockets
{
    public class DrawAppHandler : Handler
    {
        public DrawAppHandler(WebSocketConnectionManager webSocketConnectionManager): base(webSocketConnectionManager)
        {

        }
        public override async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            string marker = Encoding.UTF8.GetString(buffer, 0, result.Count);
            await SendMessageToAllAsync(marker);
        }
    }
}
