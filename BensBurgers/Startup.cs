using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BensBurgers.Startup))]
namespace BensBurgers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
