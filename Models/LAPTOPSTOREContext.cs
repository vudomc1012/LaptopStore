using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LaptopStore.Models
{
    public partial class LAPTOPSTOREContext : DbContext
    {
        public LAPTOPSTOREContext()
        {
        }

        public LAPTOPSTOREContext(DbContextOptions<LAPTOPSTOREContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BienTheSanPham> BienTheSanPhams { get; set; } = null!;
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-G14\\SQLEXPRESS;Initial Catalog=LAPTOPSTORE;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BienTheSanPham>(entity =>
            {
                entity.HasKey(e => e.IdbienThe)
                    .HasName("PK__BienTheS__9463A93DF9BCD6A6");

                entity.ToTable("BienTheSanPham");

                entity.Property(e => e.IdbienThe)
                    .ValueGeneratedNever()
                    .HasColumnName("IDBienThe");

                entity.Property(e => e.CauHinh)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdsanPham).HasColumnName("IDSanPham");

                entity.HasOne(d => d.IdsanPhamNavigation)
                    .WithMany(p => p.BienTheSanPhams)
                    .HasForeignKey(d => d.IdsanPham)
                    .HasConstraintName("FK__BienTheSa__IDSan__3C69FB99");
            });

            modelBuilder.Entity<DanhMucSanPham>(entity =>
            {
                entity.HasKey(e => e.IddanhMuc)
                    .HasName("PK__DanhMucS__DF6C0BD2929C276A");

                entity.ToTable("DanhMucSanPham");

                entity.Property(e => e.IddanhMuc)
                    .ValueGeneratedNever()
                    .HasColumnName("IDDanhMuc");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.TenDanhMuc).HasMaxLength(150);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham)
                    .HasName("PK__SanPham__9D45E58A66F4F058");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdsanPham)
                    .ValueGeneratedNever()
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.IddanhMuc).HasColumnName("IDDanhMuc");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IddanhMucNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.IddanhMuc)
                    .HasConstraintName("FK__SanPham__IDDanhM__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
