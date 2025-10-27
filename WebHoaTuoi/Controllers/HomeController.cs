using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHoaTuoi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/GioiThieu
        public ActionResult GioiThieu()
        {
            ViewBag.Title = "Giới Thiệu";
            return View();
        }

        // GET: Home/LienHe
        public ActionResult LienHe()
        {
            ViewBag.Title = "Liên Hệ";
            return View();
        }
    }
}