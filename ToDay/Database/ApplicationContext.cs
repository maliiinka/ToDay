using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDay.Database
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Models.Task> tasks => Set<Models.Task>();
        public DbSet<Models.Efficiency> efficiencies => Set<Models.Efficiency>();

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=toDay;Include Error Detail=true;Username=toDay;Password=toDay");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
