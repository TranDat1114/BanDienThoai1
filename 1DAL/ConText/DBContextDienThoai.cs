using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1DAL.Models;
using _1DAL.Configuration;
using _1DAL.Extensions;
namespace _1DAL.ConText
{
    public class DBContextDienThoai : DbContext
    {
        public DBContextDienThoai()
        {
        }
        public DBContextDienThoai(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Imei> Imeis { get; set; }
        public DbSet<ChucVu> chucVus { get; set; }
        public DbSet<HangSX> hangSXs { get; set; }
        public DbSet<DungLuong> dungLuongs { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<DienThoaiCT> dienThoaiCTs { get; set; }
        public DbSet<DienThoai> dienThoais { get; set; }
        public DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        public DbSet<MauSac> mauSacs { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
       
        public DbSet<KhachHang> khachHangs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChucVuConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonCTConfiguration());
            
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new ImeiConfiguration());
            modelBuilder.ApplyConfiguration(new DienThoaiConfiguration());
            modelBuilder.ApplyConfiguration(new DienThoaiCTConfiguration());
            modelBuilder.ApplyConfiguration(new DungLuongConfiguration());
            modelBuilder.ApplyConfiguration(new HangSXConfiguration());
            modelBuilder.ApplyConfiguration(new MauSacConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed(); //gọi cái này để seeding data
        }
    }
}
