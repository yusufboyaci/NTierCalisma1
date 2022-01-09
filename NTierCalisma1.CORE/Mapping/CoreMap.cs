using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierCalisma1.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.CORE.Mapping
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("ID");
            builder.Property(x => x.Status).IsRequired(true);
            builder.Property(x => x.CreatedComputerName).HasColumnName("Oluşturulan Bilgisayar Adı").IsRequired(false);
            builder.Property(x => x.CreatedDate).HasColumnName("Oluşturulma Zamanı").IsRequired(false);
            builder.Property(x => x.CreatedADUserName).HasColumnName("Oluşturulan Kullanıcı Admin Adı").IsRequired(false);
            builder.Property(x => x.CreatedBy).HasColumnName("Oluşturan Kişi").IsRequired(false);
            builder.Property(x => x.CreatedIP).HasColumnName("Oluşturulan IP Adresi").IsRequired(false);


            builder.Property(x => x.ModifiedComputerName).HasColumnName("Güncellenen Bilgisayar Adı").IsRequired(false);
            builder.Property(x => x.ModifiedDate).HasColumnName("Güncellenen Zamanı").IsRequired(false);
            builder.Property(x => x.ModifiedADUserName).HasColumnName("Güncellenen Kullanıcı Admin Adı").IsRequired(false);
            builder.Property(x => x.ModifiedBy).HasColumnName("Güncellenen Kişi").IsRequired(false);
            builder.Property(x => x.ModifiedIP).HasColumnName("Güncellenen IP Adresi").IsRequired(false);

        }
    }
}
