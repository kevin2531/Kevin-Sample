using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAMPLE_WEBSITE.Startup))]
namespace SAMPLE_WEBSITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
