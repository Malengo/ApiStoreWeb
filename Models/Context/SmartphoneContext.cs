using Microsoft.EntityFrameworkCore;


namespace ApiStoreWeb.Models.Context
{
    public class SmartphoneContext : DbContext
    {
        public SmartphoneContext(DbContextOptions<SmartphoneContext> options) : base(options)
        {
        }

        public DbSet<Smartphone> smartphones {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
           
            modelBuilder.Entity<Smartphone>().ToTable("smartphone");
        }
    }
}
