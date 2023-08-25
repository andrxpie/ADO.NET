using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class CAccountCfgs : IEntityTypeConfiguration<CAccount>
    {
        public void Configure(EntityTypeBuilder<CAccount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
