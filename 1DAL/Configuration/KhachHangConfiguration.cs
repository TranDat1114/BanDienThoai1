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
    public class KhachHangConfiguration : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.MaKH);
            builder.Property(x => x.TenKH).HasColumnType("nvarchar(100)");
            builder.Property(p => p.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(p => p.SDT).HasColumnType("nvarchar(12)");


        }
    }
}
