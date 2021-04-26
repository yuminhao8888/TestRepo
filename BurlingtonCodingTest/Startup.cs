using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BurlingtonCodingTest.Startup))]
namespace BurlingtonCodingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
