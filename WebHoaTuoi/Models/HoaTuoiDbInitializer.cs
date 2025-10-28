using System.Collections.Generic;
using System.Data.Entity;

namespace WebHoaTuoi.Models
{
    public class HoaTuoiDbInitializer : DropCreateDatabaseIfModelChanges<HoaTuoiDbContext>
    {
        protected override void Seed(HoaTuoiDbContext context)
        {
            // Thêm loại sản phẩm
            var loais = new List<LoaiSP>
            {
                new LoaiSP { MaLoaiSP = "L1", TenLoaiSP = "Hoa Hồng" },
                new LoaiSP { MaLoaiSP = "L2", TenLoaiSP = "Hoa Ly" },
                new LoaiSP { MaLoaiSP = "L3", TenLoaiSP = "Hoa Cúc" }
            };
            loais.ForEach(l => context.LoaiSPs.Add(l));
            context.SaveChanges();

            // Thêm sản phẩm
            var sanPhams = new List<SanPham>
            {
                new SanPham { MaSP = "SP1", TenSP = "Bó Hoa Hồng Đỏ", MaLoaiSP = "L1", SoLuong = 10, DonGia = 150000, Hinh = "hoa-hong-do.jpg" },
                new SanPham { MaSP = "SP2", TenSP = "Giỏ Hoa Ly Trắng", MaLoaiSP = "L2", SoLuong = 8, DonGia = 200000, Hinh = "ly-trang.webp" },
                new SanPham { MaSP = "SP3", TenSP = "Chậu Hoa Cúc Vàng", MaLoaiSP = "L3", SoLuong = 12, DonGia = 120000, Hinh = "cucvang.jpg" }
            };
            sanPhams.ForEach(sp => context.SanPhams.Add(sp));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
