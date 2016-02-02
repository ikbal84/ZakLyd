using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZakLyd.Startup))]
namespace ZakLyd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
