using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VbayTest.Startup))]
namespace VbayTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
