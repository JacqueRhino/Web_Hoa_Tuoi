using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebHoaTuoi.Models;

namespace WebHoaTuoi.Controllers
{
    public class SanPhamController : Controller
    {
        private HoaTuoiDbContext db = new HoaTuoiDbContext();

        public ActionResult Index()
        {
            // Lấy danh sách sản phẩm kèm thông tin loại sản phẩm
            var sanPhams = db.SanPhams.Include("LoaiSP").ToList();
            return View(sanPhams);
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var sanPham = db.SanPhams.Include("LoaiSP").FirstOrDefault(s => s.MaSP == id);

            if (sanPham == null)
            {
                return HttpNotFound();
            }

            return View(sanPham);
        }

        // GET: SanPham/TheoLoai/5
        public ActionResult TheoLoai(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var sanPhams = db.SanPhams
                .Include("LoaiSP")
                .Where(s => s.MaLoaiSP == id)
                .ToList();

            ViewBag.TenLoai = db.LoaiSPs.Find(id)?.TenLoaiSP ?? "Tất cả sản phẩm";

            return View("Index", sanPhams);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}