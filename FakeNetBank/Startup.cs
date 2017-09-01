using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FakeNetBank.Startup))]
namespace FakeNetBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
