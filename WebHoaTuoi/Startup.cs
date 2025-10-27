using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHoaTuoi.Startup))]
namespace WebHoaTuoi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
