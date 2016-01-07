using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTestWeb.Startup))]
namespace GitHubTestWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
