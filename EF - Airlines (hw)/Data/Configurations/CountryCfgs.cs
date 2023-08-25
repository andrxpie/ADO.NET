using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class CountryCfgs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "USA" },
                new Country() { Id = 3, Name = "Poland" },
                new Country() { Id = 4, Name = "Switzerland" },
                new Country() { Id = 5, Name = "German" },
                new Country() { Id = 6, Name = "Turkey" },
                new Country() { Id = 7, Name = "Japan" },
                new Country() { Id = 8, Name = "China" },
                new Country() { Id = 9, Name = "Greenland" },
                new Country() { Id = 10, Name = "Iceland" },
                new Country() { Id = 11, Name = "UK" },
            });

            builder.HasKey(x => x.Id).HasName("Countries");
        }
    }
}
