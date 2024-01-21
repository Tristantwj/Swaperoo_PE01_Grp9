using Microsoft.AspNetCore.SignalR;

namespace Swaperoo_PE01_Grp9.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
