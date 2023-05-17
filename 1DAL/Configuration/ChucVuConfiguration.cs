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
    public class ChucVuConfiguration : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.ToTable("ChucVu");
            builder.HasKey(p => p.MaCV);
            builder.Property(x => x.MaCV).UseIdentityColumn(1, 1);
            builder.Property(p => p.TenCV).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
