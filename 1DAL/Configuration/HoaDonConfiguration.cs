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
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            // Set khóa chính
            builder.HasKey(x => x.MaHD);
            builder.Property(x => x.MaHD).UseIdentityColumn(1, 1);

            builder.HasOne(p => p.NhanVienS).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaNV);

            builder.HasOne(p => p.KhachHangS).WithMany(p => p.HoaDons).HasForeignKey(p => p.MaKH);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.NgayBan).IsRequired();
            builder.Property(x => x.Ghichu).HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
            
        }
    }
}
