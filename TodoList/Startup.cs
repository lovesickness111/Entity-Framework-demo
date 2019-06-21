using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoList.Startup))]
namespace TodoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
