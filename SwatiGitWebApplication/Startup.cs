using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwatiGitWebApplication.Startup))]
namespace SwatiGitWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
