using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Tarea_17_11.Models;


namespace Tarea_17_11.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>();
        }
    }
}
