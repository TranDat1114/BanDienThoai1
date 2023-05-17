using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _1DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace _1DAL.Configuration
{
    internal class DienThoaiCTConfiguration : IEntityTypeConfiguration<DienThoaiCT>
    {
        public void Configure(EntityTypeBuilder<DienThoaiCT> builder)
        {
            builder.ToTable("DienThoaiCT"); // Đặt tên bảng
            builder.HasKey(x => x.MaDTCT); // set khóa chính
            builder.Property(x => x.MaDTCT).UseIdentityColumn(1, 1);
            // cấu trúc dữ liệu

            builder.Property(p => p.SoLuong).IsRequired();
            builder.Property(p=>p.MaQR).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.GiaNhap).IsRequired();
            builder.Property(p => p.GiaBan).IsRequired();
            builder.Property(p => p.LinkAnh).HasColumnType("nvarchar(100)").IsRequired();
            // set khóa ngoại
            builder.HasOne(x => x.DienThoaiS).WithMany(p=>p.DienThoaiCTS).HasForeignKey(p => p.MaDT);
            builder.HasOne(x => x.DungLuongS).WithMany(p => p.DienThoaiCTS).HasForeignKey(p => p.MaDungLuong);
            builder.HasOne(x => x.MauSacS).WithMany(p => p.DienThoaiCTS).HasForeignKey(p => p.MaMau);
            builder.HasOne(x => x.HangSXS).WithMany(p => p.DienThoaiCTS).HasForeignKey(p => p.MaHang);
            builder.HasOne(x => x.ImeiS).WithMany(p => p.DienThoaiCTs).HasForeignKey(p => p.MaImei);


        }
    }
}
