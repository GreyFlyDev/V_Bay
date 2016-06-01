using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vbay2.Startup))]
namespace Vbay2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
