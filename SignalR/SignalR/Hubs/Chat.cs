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

        /// <summary>
        /// 群聊的發送訊息
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="message"></param>
        /// <param name="roomName"></param>
        public void SendMessageToRoom(string userName, string message,string roomName)
        {
            this.Clients.Group(roomName).recievMessage(userName, message);
        }

        /// <summary>
        /// 加入群聊
        /// </summary>
        /// <param name="roomName"></param>
        public void JoinRoom(string roomName)
        {
            this.Groups.Add(this.Context.ConnectionId, roomName);
        }

        /// <summary>
        /// 離開群聊
        /// </summary>
        /// <param name="roomName"></param>
        public void LeaveRoom(string roomName)
        {
            this.Groups.Remove(this.Context.ConnectionId, roomName);
        }
    }
}