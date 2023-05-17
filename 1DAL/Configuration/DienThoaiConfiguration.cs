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
    internal class DienThoaiConfiguration : IEntityTypeConfiguration<DienThoai>
    {
        public void Configure(EntityTypeBuilder<DienThoai> builder)
        {
            builder.ToTable("DienThoai"); // Đặt tên bảng
            builder.HasKey(x => x.MaDT); // Set khóa chính
            builder.Property(x => x.MaDT).UseIdentityColumn(1, 1);
            builder.Property(p=>p.TrangThai).IsRequired();
         
            // Cấu trúc dữ liệu
            builder.Property(p => p.TenDT).HasColumnType("nvarchar(50)").IsRequired(); // nvarchar(50) not null
        }
    }
}
