using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(Cafe.Startup))]

namespace Cafe
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}