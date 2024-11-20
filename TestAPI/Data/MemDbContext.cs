using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    /// <summary>
    /// Context Memory Database
    /// </summary>
    public class MemDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MemDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("dbtest");
        }

        public DbSet<MarcasAutos> MarcasAutos { get; set; }
    }
}
