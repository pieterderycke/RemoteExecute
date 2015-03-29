using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RemoteExecute.Startup))]
namespace RemoteExecute
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
