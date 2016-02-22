using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitcicd.Startup))]
namespace gitcicd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
