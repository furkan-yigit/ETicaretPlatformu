using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class CartLineConfig : BaseEntityConfig<CartLine>
    {
        public new void Configure(EntityTypeBuilder<CartLine> builder)
        {
            builder.HasKey(cl => cl.Id);
            builder.Property(cl => cl.Quantity).IsRequired();

            builder.HasOne(cl => cl.Product)
                   .WithMany()
                   .HasForeignKey(cl => cl.ProductId);

            builder.HasOne(cl => cl.Cart)
                   .WithMany(c => c.CartLines)
                   .HasForeignKey(cl => cl.CartId);

            builder.Property(cl => cl.CreateDate).IsRequired();
            builder.Property(cl => cl.UpdateDate);
            builder.Property(cl => cl.DeleteDate);
            builder.Property(cl => cl.Status).IsRequired();

            base.Configure(builder);

        }
    }
}
