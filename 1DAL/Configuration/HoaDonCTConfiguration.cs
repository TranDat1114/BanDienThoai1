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
    public class HoaDonCTConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonCT");
            builder.HasKey(p => new { p.MaDTCT, p.MaHD });

         
            builder.HasOne(p => p.DienThoaiCTS).WithMany(p => p.HoaDonCTs).HasForeignKey(p => p.MaDTCT);
            builder.HasOne(p => p.HoaDonS).WithMany(p => p.HoaDonChiTietS).HasForeignKey(p => p.MaHD);


            builder.Property(p => p.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(p=>p.DonGia).HasColumnType("int").IsRequired();
        }
    }
}
