using System;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<DatabaseModels.Student> Students { get; set; }
        public DbSet<DatabaseModels.Group> Groups { get; set; }
        public DbSet<DatabaseModels.Curator> Curators { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=postgres");
        }

    }
}
