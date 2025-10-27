using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using WebHoaTuoi.Models;
using WebHoaTuoi.DAL;

namespace WebHoaTuoi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Thiết lập Database Initializer
            Database.SetInitializer<HoaTuoiDbContext>(new HoaTuoiInitializer());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}