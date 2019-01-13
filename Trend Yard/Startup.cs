using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trend_Yard.Startup))]
namespace Trend_Yard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
