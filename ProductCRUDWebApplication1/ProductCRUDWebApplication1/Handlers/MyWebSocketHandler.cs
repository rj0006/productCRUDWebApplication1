using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebSockets;

namespace ProductCRUDWebApplication1.Handlers
{
    public class MyWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection _clients = new WebSocketCollection();

        public MyWebSocketHandler()
        {
        }

        public override void OnOpen()
        {
            _clients.Add(this);
        }

        public override void OnMessage(string message)
        {
            // Handle incoming message (for example, echo back to client)
            this.Send("Echo: " + message);
        }

        public override void OnClose()
        {
            _clients.Remove(this);
        }

        public static void BroadcastMessage(string message)
        {
            foreach (var client in _clients)
            {
                client.Send(message);
            }
        }
    }
}