using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Loadings
{
    public class ShopCfgs : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.Property(x => x.Name).IsRequired();

            builder.HasKey(x => x.Id).HasName("Shops");
            builder.HasMany(x => x.Workers).WithOne(x => x.Shop).IsRequired().HasForeignKey(x => x.ShopId);
            builder.HasMany(x => x.Products).WithMany(x => x.Shops);
        }
    }
}
