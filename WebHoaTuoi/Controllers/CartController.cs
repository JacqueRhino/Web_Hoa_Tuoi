using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebHoaTuoi.Models;

namespace WebHoaTuoi.Controllers
{
    public class CartController : Controller
    {
        private HoaTuoiDbContext db = new HoaTuoiDbContext();

        // Helper method: get cart from session
        private List<CartItem> GetCart()
        {
            var cart = Session["Cart"] as List<CartItem>;
            if (cart == null)
            {
                cart = new List<CartItem>();
                Session["Cart"] = cart;
            }
            return cart;
        }

        // Add item to cart
        public ActionResult AddToCart(string id)
        {
            var sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
                return HttpNotFound();

            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.MaSP == id);

            if (item == null)
            {
                cart.Add(new CartItem
                {
                    MaSP = sanPham.MaSP,
                    TenSP = sanPham.TenSP,
                    DonGia = sanPham.DonGia,
                    SoLuong = 1,
                    Hinh = sanPham.Hinh
                });
            }
            else
            {
                item.SoLuong++;
            }

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        // Show cart
        public ActionResult Index()
        {
            var cart = GetCart();
            ViewBag.Total = cart.Sum(x => x.ThanhTien);
            return View(cart);
        }

        // Remove item
        public ActionResult Remove(string id)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.MaSP == id);
            if (item != null)
                cart.Remove(item);

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        // Update quantity
        [HttpPost]
        public ActionResult Update(string id, int quantity)
        {
            var cart = GetCart();
            var item = cart.FirstOrDefault(x => x.MaSP == id);
            if (item != null && quantity > 0)
                item.SoLuong = quantity;

            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        // Checkout placeholder
        public ActionResult Checkout()
        {
            Session.Remove("Cart");
            ViewBag.Message = "Thank you for your order!";
            return View();
        }
    }
}
