using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaVestir.Startup))]
namespace TiendaVestir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
