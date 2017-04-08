using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Cafe.Hubs
{
    public class OrderHub : Hub
    {
        public override Task OnConnected()
        {


            return base.OnConnected();
        }
    }
}