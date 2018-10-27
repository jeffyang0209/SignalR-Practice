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
        public void HelloWord()
        { 
            // 執行Cleint端的JS函式名稱
            Clients.All.hello();
        }
    }
}