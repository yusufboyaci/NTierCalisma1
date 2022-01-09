using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierCalisma1.CORE.Mapping;
using NTierCalisma1.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.ENTITIES.Mapping
{
    public class OrderDetailMap : CoreMap<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(x => x.Quantity).IsRequired(true);
            base.Configure(builder);
        }
    }
}
