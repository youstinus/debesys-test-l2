using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab1Test1.Startup))]
namespace Lab1Test1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
