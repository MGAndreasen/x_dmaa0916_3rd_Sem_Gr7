using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(Booking.Web.Startup))]
namespace Booking.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //ConfigureAuth(app);
            //app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //Path.Combine(Directory.GetCurrentDirectory(), @"MyStaticFiles")),
            //    RequestPath = new PathString("/StaticFiles")
            //});
        }
    }
}
