using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotations
{
    public class PositionCfgs : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(new[]
            {
                new Position { Id = 1, Name = "Boss" },
                new Position { Id = 2, Name = "Accountant" },
                new Position { Id = 3, Name = "Worker" },
            });
        }
    }
}
