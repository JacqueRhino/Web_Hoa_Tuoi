using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHoaTuoi.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiSP { get; set; }

        public int SoLuong { get; set; }

        // SỬA: Xóa Column attribute, để EF tự động xử lý
        public decimal DonGia { get; set; }

        [StringLength(500)]
        public string Hinh { get; set; }

        // Navigation property
        [ForeignKey("MaLoaiSP")]
        public virtual LoaiSP LoaiSP { get; set; }
    }
}