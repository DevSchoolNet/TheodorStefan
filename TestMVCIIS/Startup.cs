using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCIIS.Startup))]
namespace TestMVCIIS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
