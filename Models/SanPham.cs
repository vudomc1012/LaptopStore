using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Models
{
    public class SanPham
    {
        [Key]
        public int IDSanPham { get; set; }
        public int IDDanhMuc { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }

        [ForeignKey("IDDanhMuc")]
        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
        public virtual ICollection<BienTheSanPham> BienTheSanPhams { get; set; }
    }
}
