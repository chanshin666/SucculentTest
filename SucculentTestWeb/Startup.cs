using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SucculentTestWeb.Startup))]
namespace SucculentTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
