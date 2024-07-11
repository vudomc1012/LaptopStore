using LaptopStore.ClassDB;
using LaptopStore.DAL;
using System.Data.Entity;
public class Program
{
    static void Main(string[] args)
    {
        var quanLyLaptop = new QuanLyLaptop();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("0. Show sản phẩm");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Sửa sản phẩm");
            Console.WriteLine("3. Xóa sản phẩm");
            Console.WriteLine("4. Thêm biến thể sản phẩm");
            Console.WriteLine("5. Sửa biến thể sản phẩm");
            Console.WriteLine("6. Xóa biến thể sản phẩm");
            Console.WriteLine("7. Thoát");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    quanLyLaptop.HienThiToanBoSanPham();
                    break;
                case "1":
                    quanLyLaptop.ThemSanPham();
                    break;
                case "2":
                    quanLyLaptop.SuaSanPham();
                    break;
                case "3":
                    quanLyLaptop.XoaSanPham();
                    break;
                case "4":
                    quanLyLaptop.ThemBienTheSanPham();
                    break;
                case "5":
                    quanLyLaptop.SuaBienTheSanPham();
                    break;
                case "6":
                    quanLyLaptop.XoaBienTheSanPham();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}