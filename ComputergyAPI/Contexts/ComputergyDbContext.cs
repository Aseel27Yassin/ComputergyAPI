using ComputergyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComputergyAPI.Contexts
{
    public class ComputergyDbContext : DbContext
    {
        public ComputergyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; } //configure or mark Person class as table in DateBase

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
