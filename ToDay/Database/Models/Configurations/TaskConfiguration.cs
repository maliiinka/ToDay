using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDay.Database.Models.Configurations
{
    internal class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.ToTable("Task").Property("name").HasMaxLength(100).IsRequired();
            builder.ToTable("Task").Property("description").HasMaxLength(350).IsRequired();
            builder.ToTable("Task").Property("created_at").IsRequired();
            builder.ToTable("Task").Property("sheduled_for").IsRequired();
            builder.ToTable("Task").Property("is_active").HasDefaultValue(true);
            builder.ToTable("Task").Property("is_priority").HasDefaultValue(false);
        }
    }
}
