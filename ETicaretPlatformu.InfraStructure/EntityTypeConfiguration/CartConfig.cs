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
        public new void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.UserId).IsRequired();

            builder.HasMany(c => c.CartLines)
                   .WithOne(cl => cl.Cart)
                   .HasForeignKey(cl => cl.CartId);

            builder.Property(c => c.CreateDate).IsRequired();
            builder.Property(c => c.UpdateDate);
            builder.Property(c => c.DeleteDate);
            builder.Property(c => c.Status).IsRequired();

            base.Configure(builder);

        }
    }
}
