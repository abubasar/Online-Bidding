using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBidding.Web.Startup))]
namespace OnlineBidding.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
