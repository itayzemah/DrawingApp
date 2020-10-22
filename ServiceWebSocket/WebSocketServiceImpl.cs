using AppContracts;
using AppContracts.DTO.Marker;
using AppContracts.interfaces;
using ItayDrowingApp.AppContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceWebSocket
{
    [Register(Policy.Transient, typeof(IWebSocketService))]

    public class WebSocketServiceImpl : IWebSocketService
    {
        Dictionary<string, List<IReceiver>> _sharedDocuments;
        public IMarkerService markerService { get; set; }

        public WebSocketServiceImpl()
        {
            _sharedDocuments = new Dictionary<string, List<IReceiver>>();
        }

       


        private async Task Close(WebSocket webSocket, WebSocketReceiveResult msg)
        {
            await webSocket.CloseAsync(msg.CloseStatus.Value, msg.CloseStatusDescription, CancellationToken.None);
        }

        public void Add(string docID, string userID, WebSocket socket)
        {
            if (!_sharedDocuments.ContainsKey(docID))
            {
                _sharedDocuments.Add(docID, new List<IReceiver>());
            }
            var receiver = new Receiver(userID, socket);
            _sharedDocuments[docID].Add(receiver);
        }


        public async Task SendToAllLesteners(string marker, string docId)
        {
            foreach (var user in _sharedDocuments[docId])
            {
                await Send(user.Socket, marker);
            }
        }
        public async Task Send(WebSocket socket, string message)
        {
            if (socket.State == WebSocketState.Open)
            {
            await socket.SendAsync(new ArraySegment<byte>(Encoding.ASCII.GetBytes(message), 0, message.Length),
                WebSocketMessageType.Text, true, CancellationToken.None);
            }
                return;
        }
        
    }
}
