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
    public class CategoryCfgs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new[]
            {
                new Category() { Id = 1, Name = "Drink" },
                new Category() { Id = 2, Name = "Eat" },
                new Category() { Id = 3, Name = "Cloth" },
                new Category() { Id = 4, Name = "Electronic" },
                new Category() { Id = 5, Name = "For Home" },
            });

            builder.HasKey(x => x.Id).HasName("Categories");
        }
    }
}
