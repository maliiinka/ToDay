using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDay.Database.Models.Configurations
{
    internal class EfficiencyConfiguration : IEntityTypeConfiguration<Efficiency>
    {
        public void Configure(EntityTypeBuilder<Efficiency> builder)
        {
            builder.ToTable("Efficiency").Property("day").IsRequired();
            builder.ToTable("Efficiency").Property("completed_tasks").HasDefaultValue(0);
        }
    }
}
