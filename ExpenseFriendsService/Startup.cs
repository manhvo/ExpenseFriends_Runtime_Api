using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ExpenseFriendsService.Startup))]

namespace ExpenseFriendsService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}