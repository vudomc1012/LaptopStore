using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.DAL
{
    public class QuanLyLaptop
    {
        public void HienThiToanBoSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                var sanPhams = context.SanPhams.Include("DanhMucSanPham").Include("BienTheSanPhams").ToList();
                foreach (var sanPham in sanPhams)
                {
                    Console.WriteLine($"Sản phẩm: {sanPham.TenSanPham}");
                    Console.WriteLine($"Danh mục: {sanPham.IddanhMuc}");
                    Console.WriteLine($"Mô tả: {sanPham.MoTa}");

                    foreach (var bienThe in sanPham.BienTheSanPhams)
                    {
                        Console.WriteLine($"Biến thể: {bienThe.CauHinh}");
                        Console.WriteLine($"Giá: {bienThe.Gia}");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void ThemSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập tên danh mục:");
                string tenDanhMuc = Console.ReadLine();
                Console.WriteLine("Nhập mô tả danh mục:");
                string moTaDanhMuc = Console.ReadLine();

                var danhMuc = new DanhMucSanPham
                {
                    TenDanhMuc = tenDanhMuc,
                    MoTa = moTaDanhMuc
                };

                Console.WriteLine("Nhập tên sản phẩm:");
                string tenSanPham = Console.ReadLine();
                Console.WriteLine("Nhập mô tả sản phẩm:");
                string moTaSanPham = Console.ReadLine();

                var sanPham = new SanPham
                {
                    TenSanPham = tenSanPham,
                    MoTa = moTaSanPham
                };

                context.DanhMucSanPhams.Add(danhMuc);
                context.SanPhams.Add(sanPham);
                context.SaveChanges();
                Console.WriteLine("Thêm sản phẩm thành công.");
            }
        }
        public void SuaSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập ID sản phẩm cần sửa:");
                int IDSanPham = int.Parse(Console.ReadLine());
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.IdsanPham == IDSanPham);
                if (sanPham != null)
                {
                    Console.WriteLine("Nhập tên sản phẩm mới:");
                    sanPham.TenSanPham = Console.ReadLine();
                    Console.WriteLine("Nhập mô tả sản phẩm mới:");
                    sanPham.MoTa = Console.ReadLine();
                    context.SaveChanges();
                    Console.WriteLine("Sửa sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Sản phẩm không tồn tại.");
                }
            }
        }

        public void XoaSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập ID sản phẩm cần xóa:");
                int IDSanPham = int.Parse(Console.ReadLine());
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.IdsanPham == IDSanPham);
                if (sanPham != null)
                {
                    context.SanPhams.Remove(sanPham);
                    context.SaveChanges();
                    Console.WriteLine("Xóa sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Sản phẩm không tồn tại.");
                }
            }
        }
        public void ThemBienTheSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập ID sản phẩm:");
                int IDSanPham = int.Parse(Console.ReadLine());
                var sanPham = context.SanPhams.FirstOrDefault(sp => sp.IdsanPham == IDSanPham);
                if (sanPham != null)
                {
                    Console.WriteLine("Nhập cấu hình biến thể:");
                    string cauHinh = Console.ReadLine();
                    Console.WriteLine("Nhập giá biến thể:");
                    int gia = int.Parse(Console.ReadLine());

                    var bienThe = new BienTheSanPham
                    {
                        IdsanPham = IDSanPham,
                        CauHinh = cauHinh,
                        Gia = gia
                    };

                    context.BienTheSanPhams.Add(bienThe);
                    context.SaveChanges();
                    Console.WriteLine("Thêm biến thể sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Sản phẩm không tồn tại.");
                }
            }
        }

        public void SuaBienTheSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập ID biến thể cần sửa:");
                int IDBienThe = int.Parse(Console.ReadLine());
                var bienThe = context.BienTheSanPhams.FirstOrDefault(bt => bt.IdbienThe == IDBienThe);
                if (bienThe != null)
                {
                    Console.WriteLine("Nhập cấu hình biến thể mới:");
                    bienThe.CauHinh = Console.ReadLine();
                    Console.WriteLine("Nhập giá biến thể mới:");
                    bienThe.Gia = int.Parse(Console.ReadLine());
                    context.SaveChanges();
                    Console.WriteLine("Sửa biến thể sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Biến thể sản phẩm không tồn tại.");
                }
            }
        }

        public void XoaBienTheSanPham()
        {
            using (var context = new LAPTOPSTOREContext())
            {
                Console.WriteLine("Nhập ID biến thể cần xóa:");
                int IDBienThe = int.Parse(Console.ReadLine());
                var bienThe = context.BienTheSanPhams.FirstOrDefault(bt => bt.IdbienThe == IDBienThe);
                if (bienThe != null)
                {
                    context.BienTheSanPhams.Remove(bienThe);
                    context.SaveChanges();
                    Console.WriteLine("Xóa biến thể sản phẩm thành công.");
                }
                else
                {
                    Console.WriteLine("Biến thể sản phẩm không tồn tại.");
                }
            }
        }

    }
}