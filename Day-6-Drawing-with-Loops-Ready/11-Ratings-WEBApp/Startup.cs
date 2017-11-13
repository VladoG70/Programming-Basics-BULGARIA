using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11_Ratings_WEBApp.Startup))]
namespace _11_Ratings_WEBApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
