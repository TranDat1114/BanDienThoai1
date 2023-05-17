using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _1DAL.Models;

namespace _1DAL.Configuration
{
    internal class DungLuongConfiguration : IEntityTypeConfiguration<DungLuong>
    {
        public void Configure(EntityTypeBuilder<DungLuong> builder)
        {
            builder.ToTable("DungLuong"); // Đặt tên bảng
            builder.HasKey(x => x.MaDungLuong);
            builder.Property(x => x.MaDungLuong).UseIdentityColumn(1, 1);
            builder.Property(p=>p.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(p => p.SoDungLuong).HasColumnName("SoDungLuong").HasColumnType("nvarchar(30)").IsRequired();
        }
    }
}
