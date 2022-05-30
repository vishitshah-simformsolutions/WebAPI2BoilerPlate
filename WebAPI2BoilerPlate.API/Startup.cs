using Microsoft.Owin;
using Owin;
using WebAPI2BoilerPlate;

[assembly: OwinStartup(typeof(Startup))]
namespace WebAPI2BoilerPlate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}