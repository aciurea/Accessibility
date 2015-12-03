using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Accessibility.Startup))]
namespace Accessibility
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
