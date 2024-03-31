using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class OrderConfig:BaseEntityConfig<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UserId).IsRequired(true);
            builder.Property(x => x.User).IsRequired(true);
            builder.Property(x => x.OrderDetails).IsRequired(true);

            
            
        }
    }
}
