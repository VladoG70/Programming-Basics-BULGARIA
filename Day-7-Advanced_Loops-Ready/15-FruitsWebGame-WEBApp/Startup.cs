using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15_FruitsWebGame_WEBApp.Startup))]
namespace _15_FruitsWebGame_WEBApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
