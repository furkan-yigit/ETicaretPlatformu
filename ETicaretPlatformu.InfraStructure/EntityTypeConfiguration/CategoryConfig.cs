using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class CategoryConfig:BaseEntityConfig<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(true);
            
        }
    }
}
