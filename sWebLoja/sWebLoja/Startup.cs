using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sWebLoja.Startup))]
namespace sWebLoja
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
