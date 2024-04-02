using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class CartConfig:BaseEntityConfig<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {

            
            builder.Property(x => x.UserId).IsRequired(true);
            
            
            builder.Property(x => x.Products).IsRequired(true);
            
            base.Configure(builder);

        }
    }
}
