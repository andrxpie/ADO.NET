using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class CategoriesCfgs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();

            builder.HasData(new[]
            {
                new Category { Id = 1, Name = "Phonk" },
                new Category { Id = 2, Name = "Instrumental" },
                new Category { Id = 3, Name = "Race" },
            });
        }
    }
}
