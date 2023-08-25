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

            builder.HasData(new[]
            {
                new Product { Id = 1, Name = "G502 X PLUS", CategoryId = 4, Discount = 12, IsInStock = true, Price = 4799, Quantity = 15 },
                new Product { Id = 2, Name = "G102 LightSync", CategoryId = 4, Discount = 30, IsInStock = true, Price = 4799, Quantity = 15 },
            });
        }
    }
}
