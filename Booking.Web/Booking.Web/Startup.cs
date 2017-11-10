using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Booking.Web.Startup))]
namespace Booking.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
