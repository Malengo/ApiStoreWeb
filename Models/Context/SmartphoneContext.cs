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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Smartphone>().ToTable("smartphone");
            modelBuilder.Entity<Purchase>().ToTable("purchase");
        }
    }
}
