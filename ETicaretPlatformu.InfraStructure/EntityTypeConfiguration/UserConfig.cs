using ETicaretPlatformu.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.InfraStructure.EntityTypeConfiguration
{
    public class UserConfig:BaseEntityConfig<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NormalizedUserName).IsRequired(false);
            builder.Property(x => x.UserName).IsRequired(true);

            builder.Property(x => x.ImagePath).IsRequired(false);


            base.Configure(builder);

        }
    }
}
