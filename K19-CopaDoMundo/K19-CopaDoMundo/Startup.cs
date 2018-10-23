using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(K19_CopaDoMundo.Startup))]
namespace K19_CopaDoMundo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
