using System;
using System.Data.Entity;
using System.Collections.Generic;
using WebHoaTuoi.Models;

namespace WebHoaTuoi.DAL
{
    public class HoaTuoiInitializer : DropCreateDatabaseIfModelChanges<HoaTuoiDbContext>
    {
        protected override void Seed(HoaTuoiDbContext context)
        {
            // Thêm Loại Sản Phẩm
            var loaiSPs = new List<LoaiSP>
            {
                new LoaiSP { MaLoaiSP = "LSP01", TenLoaiSP = "Hoa Hồng" },
                new LoaiSP { MaLoaiSP = "LSP02", TenLoaiSP = "Hoa Tulip" },
                new LoaiSP { MaLoaiSP = "LSP03", TenLoaiSP = "Hoa Hướng Dương" },
                new LoaiSP { MaLoaiSP = "LSP04", TenLoaiSP = "Hoa Ly" },
                new LoaiSP { MaLoaiSP = "LSP05", TenLoaiSP = "Hoa Cưới" },
                new LoaiSP { MaLoaiSP = "LSP06", TenLoaiSP = "Hoa Sinh Nhật" }
            };

            loaiSPs.ForEach(l => context.LoaiSPs.Add(l));
            context.SaveChanges();

            // Thêm Sản Phẩm
            var sanPhams = new List<SanPham>
            {
                new SanPham {
                    MaSP = "SP001",
                    TenSP = "Bó Hoa Hồng Đỏ Tình Yêu",
                    MaLoaiSP = "LSP01",
                    SoLuong = 25,
                    DonGia = 350000,
                    Hinh = "hoa-hong-do.jpg"
                },
                new SanPham {
                    MaSP = "SP002",
                    TenSP = "Hoa Hồng Phớt Pastel",
                    MaLoaiSP = "LSP01",
                    SoLuong = 30,
                    DonGia = 400000,
                    Hinh = "hoa-hong-hong.jpg"
                },
                new SanPham {
                    MaSP = "SP003",
                    TenSP = "Bó Tulip Hà Lan Cao Cấp",
                    MaLoaiSP = "LSP02",
                    SoLuong = 15,
                    DonGia = 550000,
                    Hinh = "tulip-ha-lan.jpg"
                },
                new SanPham {
                    MaSP = "SP004",
                    TenSP = "Hoa Hướng Dương Rực Rỡ",
                    MaLoaiSP = "LSP03",
                    SoLuong = 20,
                    DonGia = 300000,
                    Hinh = "huong-duong.jpg"
                },
                new SanPham {
                    MaSP = "SP005",
                    TenSP = "Hoa Ly Trắng Tinh Khôi",
                    MaLoaiSP = "LSP04",
                    SoLuong = 18,
                    DonGia = 450000,
                    Hinh = "hoa-ly-trang.jpg"
                },
                new SanPham {
                    MaSP = "SP006",
                    TenSP = "Bó Hoa Cưới Sang Trọng",
                    MaLoaiSP = "LSP05",
                    SoLuong = 10,
                    DonGia = 850000,
                    Hinh = "hoa-cuoi.jpg"
                },
                new SanPham {
                    MaSP = "SP007",
                    TenSP = "Hoa Sinh Nhật Đáng Yêu",
                    MaLoaiSP = "LSP06",
                    SoLuong = 22,
                    DonGia = 380000,
                    Hinh = "hoa-sinh-nhat.jpg"
                },
                new SanPham {
                    MaSP = "SP008",
                    TenSP = "Hoa Hồng Vàng Tươi Sáng",
                    MaLoaiSP = "LSP01",
                    SoLuong = 28,
                    DonGia = 320000,
                    Hinh = "hoa-hong-vang.jpg"
                },
                new SanPham {
                    MaSP = "SP009",
                    TenSP = "Tulip Đa Sắc Màu",
                    MaLoaiSP = "LSP02",
                    SoLuong = 12,
                    DonGia = 480000,
                    Hinh = "tulip-da-sac.jpg"
                },
                new SanPham {
                    MaSP = "SP010",
                    TenSP = "Hoa Ly Hồng Lãng Mạn",
                    MaLoaiSP = "LSP04",
                    SoLuong = 0,
                    DonGia = 420000,
                    Hinh = "hoa-ly-hong.jpg"
                },
                new SanPham {
                    MaSP = "SP011",
                    TenSP = "Giỏ Hoa Hướng Dương Mix",
                    MaLoaiSP = "LSP03",
                    SoLuong = 16,
                    DonGia = 520000,
                    Hinh = "gio-huong-duong.jpg"
                },
                new SanPham {
                    MaSP = "SP012",
                    TenSP = "Bó Hoa Cưới Cổ Điển",
                    MaLoaiSP = "LSP05",
                    SoLuong = 8,
                    DonGia = 950000,
                    Hinh = "hoa-cuoi-co-dien.jpg"
                }
            };

            sanPhams.ForEach(s => context.SanPhams.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}