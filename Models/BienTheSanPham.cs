using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.Models
{
    public class BienTheSanPham
    {
        [Key]
        public int IDBienThe { get; set; }
        public int IDSanPham { get; set; }
        public string CauHinh { get; set; }
        public int Gia { get; set; }

        [ForeignKey("IDSanPham")]
        public virtual SanPham SanPham { get; set; }
    }
}
