using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(owinn.Startup))]
namespace owinn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
