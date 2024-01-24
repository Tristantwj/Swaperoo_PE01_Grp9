using Microsoft.AspNetCore.SignalR;

namespace Swaperoo_PE01_Grp9.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendToUser(string user, string receiveConnectionId, string message)
        {
            await Clients.Client(receiveConnectionId).SendAsync("ReceiveMessage", user, message);
        }
        public string GetConnectionId() => Context.ConnectionId;
    }
}