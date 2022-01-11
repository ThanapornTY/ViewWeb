using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewWeb.Startup))]
namespace ViewWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
