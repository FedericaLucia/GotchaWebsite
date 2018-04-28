using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GotchaWebsite.Startup))]
namespace GotchaWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
