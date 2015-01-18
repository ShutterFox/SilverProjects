using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SilverProjects.Startup))]
namespace SilverProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
