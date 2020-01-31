using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bikes_MS_.Startup))]
namespace Bikes_MS_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
