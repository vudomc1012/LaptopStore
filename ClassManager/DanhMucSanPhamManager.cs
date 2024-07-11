﻿using LaptopStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopStore.ClassDB
{
    public class DanhMucSanPhamManager
    {
        MyDbContext myDbContext = new MyDbContext();
        public List<DanhMucSanPham> GetListProductCategory()
        {
            var listProductCategory = new List<DanhMucSanPham>();
            try
            {
                listProductCategory = myDbContext.DanhMucSanPhams.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi rồi: {ex}");
                Environment.Exit(1);
            }
            return listProductCategory;
        }
        public void AddProductCategory(DanhMucSanPham danhMucSanPham)
        {
            try
            {
                myDbContext.DanhMucSanPhams.Add(danhMucSanPham);
                myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi rồi: {ex}");
                Environment.Exit(1);
            }
        }
        public void DeleteProductCategory(DanhMucSanPham danhMucSanPham)
        {
            try
            {
                var category = myDbContext.DanhMucSanPhams
                                    .FirstOrDefault(c => c.IDDanhMuc == danhMucSanPham.IDDanhMuc);

                if (category != null)
                {
                    myDbContext.DanhMucSanPhams.Add(danhMucSanPham);
                    myDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi rồi: {ex}");
                Environment.Exit(1);
            }
        }
        public void UpdateProductCategory(DanhMucSanPham danhMucSanPham)
        {
            try
            {
                myDbContext.DanhMucSanPhams.AddOrUpdate(danhMucSanPham);
                myDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi rồi: {ex}");
                Environment.Exit(1);
            }
        }
    }
}