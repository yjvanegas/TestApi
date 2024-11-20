using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    /// <summary>
    /// Context postgresql database
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MarcasAutos> MarcasAutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarcasAutosSeed());
        }
    }
}
