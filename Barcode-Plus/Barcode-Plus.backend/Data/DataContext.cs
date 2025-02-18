using Barcode_Plus.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Barcode_Plus.backend.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
                
        }
        public DbSet<College>colleges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<College>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<College>().HasIndex(c => c.NameAr).IsUnique();
        }

    }
}
