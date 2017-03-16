using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grm.BaseDados.WebAppl.Startup))]
namespace Grm.BaseDados.WebAppl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
