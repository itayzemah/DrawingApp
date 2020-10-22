//using System;
//using System.Collections.Generic;
//using System.Net.WebSockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace WebSockets
//{
//    public class DrawAppHandler : Handler
//    {
//        public DrawAppHandler(WebSocketConnectionManager webSocketConnectionManager): base(webSocketConnectionManager)
//        {

//        }
        
//        public override async Task OnConnected(WebSocket socket)
//        {
//            await base.OnConnected(socket);
//            var socketID = WebSocketConnectionManager.GetId(socket);
//            await SendMessageToAllAsync("Messase:{\"New Enter\"}");
//        }

//        public override async Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
//        {
//            string marker = Encoding.UTF8.GetString(buffer, 0, result.Count);
//            await SendMessageToAllAsync(marker);
//        }
//    }
//}
