using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonContosoNVC5.Startup))]
namespace MonContosoNVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
