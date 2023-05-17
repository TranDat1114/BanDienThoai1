using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace _1DAL.Configuration
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(p => p.MaNV);
            builder.Property(x => x.MaNV).UseIdentityColumn(1, 1);
            builder.HasOne(p=>p.ChucVuS).WithMany(p=>p.NhanVienS).HasForeignKey(p=>p.MaCV);

            builder.Property(p => p.TenNV).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.GioiTinh).IsRequired();
            builder.Property(p => p.DiaChi).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.SDT).HasColumnType("nvarchar(12)").IsRequired();
            builder.Property(p => p.NgaySinh).IsRequired();
           
            builder.Property(p => p.matKhau).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(p => p.TrangThai).IsRequired();
        }
    }
}
