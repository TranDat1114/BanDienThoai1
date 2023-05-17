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
    internal class MauSacConfiguration : IEntityTypeConfiguration<MauSac>
    {
        public void Configure(EntityTypeBuilder<MauSac> builder)
        {
            builder.ToTable("MauSac");
            builder.HasKey(x => x.MaMau);
            builder.Property(x => x.MaMau).UseIdentityColumn(1, 1);
            builder.Property(p => p.TrangThai).IsRequired();
            builder.Property(p => p.TenMau).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
