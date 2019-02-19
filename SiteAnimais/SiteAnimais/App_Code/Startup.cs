using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteAnimais.Startup))]
namespace SiteAnimais
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
