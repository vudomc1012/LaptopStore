using System;
using System.Collections.Generic;

namespace LaptopStore.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            BienTheSanPhams = new HashSet<BienTheSanPham>();
        }

        public int IdsanPham { get; set; }
        public int? IddanhMuc { get; set; }
        public string TenSanPham { get; set; } = null!;
        public string? MoTa { get; set; }

        public virtual DanhMucSanPham? IddanhMucNavigation { get; set; }
        public virtual ICollection<BienTheSanPham> BienTheSanPhams { get; set; }
    }
}
