using System;
using System.Collections.Generic;

namespace LaptopStore.Models
{
    public partial class DanhMucSanPham
    {
        public DanhMucSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int IddanhMuc { get; set; }
        public string TenDanhMuc { get; set; } = null!;
        public string? MoTa { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
