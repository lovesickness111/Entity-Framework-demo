using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodefirstExample.Startup))]
namespace CodefirstExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
