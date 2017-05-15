using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VolteFace.Startup))]
namespace VolteFace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
