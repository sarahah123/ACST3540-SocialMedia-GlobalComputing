using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetKennelDB.Startup))]
namespace PetKennelDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
