using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiveRosesTea.Startup))]
namespace FiveRosesTea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
