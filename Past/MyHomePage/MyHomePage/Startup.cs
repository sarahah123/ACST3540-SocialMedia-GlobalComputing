using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHomePage.Startup))]
namespace MyHomePage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
