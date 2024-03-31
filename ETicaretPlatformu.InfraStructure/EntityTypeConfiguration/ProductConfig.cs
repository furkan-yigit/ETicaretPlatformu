using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class ProductConfig:BaseEntityConfig<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.StockQuantity).IsRequired(true);
            builder.Property(x => x.CategoryId).IsRequired(true);
            builder.Property(x => x.Category).IsRequired(true);
            builder.Property(x => x.ImagePath).IsRequired(false);
            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
         




            base.Configure(builder);

        }
    }
}
