using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillingWebSite.Startup))]
namespace BillingWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
