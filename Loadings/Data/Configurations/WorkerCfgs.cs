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
    internal class WorkerCfgs : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(x => x.Id).HasName("Workers");
            builder.HasOne(x => x.Position).WithMany(x => x.Workers).IsRequired().HasForeignKey(x => x.PositionId);
        }
    }
}
