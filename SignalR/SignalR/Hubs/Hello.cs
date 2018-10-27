using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Hubs
{
    public class Hello : Hub
    {
        // 另一種ReName的方式
        // [HubName("Hello")]
        public void helloSignalR()
        {
            // 執行Cleint端的helloHubProxy.clien 函式
            Clients.All.helloClient("Hi");
        }
    }
}