using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantRater.mvc.Startup))]
namespace RestaurantRater.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
