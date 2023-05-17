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
    internal class HangSXConfiguration : IEntityTypeConfiguration<HangSX>
    {
        public void Configure(EntityTypeBuilder<HangSX> builder)
        {
            builder.ToTable("HangSX");
            builder.HasKey(x => x.MaHang);
            builder.Property(x => x.MaHang).UseIdentityColumn(1, 1);
            builder.Property(p=>p.TrangThai).IsRequired();
            builder.Property(p => p.TenHang).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
