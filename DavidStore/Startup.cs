using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavidStore.Startup))]
namespace DavidStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
