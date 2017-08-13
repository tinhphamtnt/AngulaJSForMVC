using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngulaJSForMVC.Startup))]
namespace AngulaJSForMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
