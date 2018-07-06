using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mosh.Vidly.Startup))]
namespace Mosh.Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
