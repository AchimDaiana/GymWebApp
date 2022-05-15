using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymWebApp.Hubs
{
    public class ChatHub : Hub
    {
/*        public async Task SendMessage(string username, string message)
        {
            //clientii din libraria r iar all vor fi toti participantii la chat
            await Clients.All.SendAsync("ReceivedMessage", username, message);
        }*/
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
