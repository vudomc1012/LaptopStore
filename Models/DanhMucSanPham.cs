using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Models
{
    public class DanhMucSanPham
    {
        [Key]
        public int IDDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string MoTa { get; set; }

        //public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
