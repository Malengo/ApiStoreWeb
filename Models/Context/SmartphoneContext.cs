using ApiStoreWeb.Models.Entites;
using Microsoft.EntityFrameworkCore;


namespace ApiStoreWeb.Models.Context
{
    public class SmartphoneContext : DbContext
    {
        public SmartphoneContext(DbContextOptions<SmartphoneContext> options) : base(options)
        {
        }

        public DbSet<Smartphone> smartphones { get; set; }
        public DbSet<Purchase> purchases { get; set; }

        public DbSet<User> user { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Smartphone>().ToTable("smartphones");
            modelBuilder.Entity<User>().ToTable("usuarios");
            modelBuilder.Entity<Purchase>().ToTable("purchase");
        }
    }
}
