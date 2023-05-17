using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace _1DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu() { MaCV = 1, TenCV = "Quản lý" },
                new ChucVu() { MaCV = 2, TenCV = "Nhân viên" }
                );
            modelBuilder.Entity<DungLuong>().HasData(
               new DungLuong() { MaDungLuong = 1, SoDungLuong = "8gb Ram/ 124gb bo nho", TrangThai =1 },
               new DungLuong() { MaDungLuong = 2, SoDungLuong = "6gb Ram/ 64gb bo nho", TrangThai = 1 }
               );
            modelBuilder.Entity<HangSX>().HasData(
                new HangSX() { MaHang = 1, TenHang = "Apple", TrangThai = 1 },
                 new HangSX() { MaHang = 2, TenHang = "Realme", TrangThai = 1 }
                );
          
            modelBuilder.Entity<MauSac>().HasData(
                new MauSac() { MaMau = 1, TenMau = "Xanh", TrangThai = 1 },
                 new MauSac() { MaMau = 2, TenMau = "Tim", TrangThai = 1 }
                );

            modelBuilder.Entity<DienThoai>().HasData(
              new DienThoai() { MaDT = 1, TenDT = "Iphone 14 Pro Max", TrangThai = 1 },
              new DienThoai() { MaDT = 2, TenDT = "Realme note 9 pro", TrangThai = 1 }

              );
            modelBuilder.Entity<Imei>().HasData(new Imei() { MaImei = 1, TenImei = "0123456789", TrangThai = true },
                new Imei() { MaImei = 2, TenImei = "0123456788", TrangThai = true });

            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien() { MaNV = 2, TenNV = "Nguyễn Văn Đạo", MaCV = 2, DiaChi = "Tuyên Quang", SDT = "0379702133", GioiTinh = 1, matKhau = "123", NgaySinh = DateTime.Now, TrangThai = 0 },
                 new NhanVien() { MaNV = 1, TenNV = "Ngô Quốc Mạnh", MaCV = 1, DiaChi = "Hà Nam", SDT = "0336253482",  GioiTinh = 1, matKhau = "123", NgaySinh = DateTime.Now, TrangThai = 0 }
                );
            modelBuilder.Entity<DienThoaiCT>().HasData(
                new DienThoaiCT() { MaDTCT = 1, MaDT = 1, MaImei = 1, GiaNhap = 100000, GiaBan = 110000, SoLuong = 50, MaDungLuong = 1, MaHang = 1, MaMau = 1, MaQR="12345",LinkAnh = "", TrangThai =true });
            modelBuilder.Entity<KhachHang>().HasData(
                new KhachHang() { MaKH=1, TenKH="Ngô Quốc Mạnh", DiaChi="Hà Nam", GioiTinh= true, SDT="0336253482", Diem = 50000},
                new KhachHang() { MaKH = 2, TenKH = "Chuyên Xem Chùa", DiaChi = "Hà Nội", GioiTinh = true, SDT = "0123456789", Diem = 50000 },
                new KhachHang() { MaKH = 3, TenKH = "Khách Vãng Lai", DiaChi = "không rõ", GioiTinh = true, SDT = "0", Diem = 0 }
                );
           
        }
    }
}
