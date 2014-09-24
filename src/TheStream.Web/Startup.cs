using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheStream.Web.Startup))]
namespace TheStream.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
