using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class ClientsCfgs : IEntityTypeConfiguration<Clients>
    {
        public void Configure(EntityTypeBuilder<Clients> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.IsMale).IsRequired();
            
            builder.HasOne(x => x.Account).WithOne(x => x.Client).HasForeignKey<Clients>(x => x.AccountId);
        }
    }
}
