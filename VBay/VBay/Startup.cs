using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VBay.Startup))]
namespace VBay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
