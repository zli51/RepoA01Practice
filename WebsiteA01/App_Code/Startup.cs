using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteA01.Startup))]
namespace WebsiteA01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
