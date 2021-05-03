using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantRaterMvc.Startup))]
namespace RestaurantRaterMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
