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
    public class ProductCfgs : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id).HasName("Products");
            builder.HasOne(x => x.Category).WithMany(x => x.Products).IsRequired().HasForeignKey(x => x.CategoryId);
        }
    }
}
