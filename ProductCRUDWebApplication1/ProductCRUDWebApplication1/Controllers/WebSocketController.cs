using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.WebSockets;
using ProductCRUDWebApplication1.Handlers;

namespace ProductCRUDWebApplication1.Controllers
{
    public class WebSocketController : Controller
    {
        public ActionResult Index()
        {
            if (HttpContext.IsWebSocketRequest)
            {
                HttpContext.AcceptWebSocketRequest(new MyWebSocketHandler());
                return new EmptyResult(); // WebSocket handling will be done by MyWebSocketHandler
            }
            else
            {
                return View("Error");
            }
        }
    }
}