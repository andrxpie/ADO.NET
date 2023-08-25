using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class ATypeCfgs : IEntityTypeConfiguration<AType>
    {
        public void Configure(EntityTypeBuilder<AType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
