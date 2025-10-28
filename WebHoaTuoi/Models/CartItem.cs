using System;

namespace WebHoaTuoi.Models
{
    [Serializable]
    public class CartItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Hinh { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;
    }
}
