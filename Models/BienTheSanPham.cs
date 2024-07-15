using System;
using System.Collections.Generic;

namespace LaptopStore.Models
{
    public partial class BienTheSanPham
    {
        public int IdbienThe { get; set; }
        public int? IdsanPham { get; set; }
        public string CauHinh { get; set; } = null!;
        public int Gia { get; set; }

        public virtual SanPham? IdsanPhamNavigation { get; set; }
    }
}
