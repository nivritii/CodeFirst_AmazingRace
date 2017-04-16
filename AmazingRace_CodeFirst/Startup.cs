using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazingRace_CodeFirst.Startup))]
namespace AmazingRace_CodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
