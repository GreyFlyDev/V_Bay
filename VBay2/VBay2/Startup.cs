using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VBay2.Startup))]
namespace VBay2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
