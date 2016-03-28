using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WuYanWeb.Startup))]
namespace WuYanWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
