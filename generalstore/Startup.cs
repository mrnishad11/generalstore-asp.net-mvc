using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(generalstore.Startup))]
namespace generalstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
