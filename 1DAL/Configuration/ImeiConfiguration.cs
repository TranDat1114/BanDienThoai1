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
    public class ImeiConfiguration : IEntityTypeConfiguration<Imei>
    {
        public void Configure(EntityTypeBuilder<Imei> builder)
        {
            builder.ToTable("Imei");
            builder.HasKey(p=>p.MaImei);
            builder.Property(x => x.MaImei).UseIdentityColumn(1, 1);
            // Set các ràng buộc cho thuộc tính
            builder.Property(x => x.TenImei).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
