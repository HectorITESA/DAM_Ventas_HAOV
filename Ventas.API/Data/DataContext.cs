using Microsoft.EntityFrameworkCore;
using Ventas.Share.Entities;

namespace Ventas.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> optios) : base(optios)
        {
            
        }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
