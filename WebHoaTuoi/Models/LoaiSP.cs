using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHoaTuoi.Models
{
    [Table("LoaiSP")]
    public class LoaiSP
    {
        [Key]
        [StringLength(10)]
        public string MaLoaiSP { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoaiSP { get; set; }

        // Navigation property
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}