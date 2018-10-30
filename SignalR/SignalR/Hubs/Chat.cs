using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Hubs
{
    public class Chat : Hub
    {
        public void SendMessage(string userName, string message)
        {
            Clients.All.recievMessage(userName, message);
        }
    }
}