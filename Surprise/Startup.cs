using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Surprise.Startup))]
namespace Surprise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
