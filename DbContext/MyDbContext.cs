using LaptopStore.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=LAPTOPSTORE")
        {
        }

        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<BienTheSanPham> BienTheSanPhams { get; set; }
    }
}
