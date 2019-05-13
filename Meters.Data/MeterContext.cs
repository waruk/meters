using Meters.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Meters.Data
{
    public class MeterContext : DbContext
    {
        public DbSet<Meter> Meters { get; set; }
        public DbSet<Index> Indexes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=meters.db");
        }

    }

}
