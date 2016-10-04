using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tentickers.Startup))]
namespace Tentickers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
