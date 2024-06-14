using Microsoft.EntityFrameworkCore;

namespace OrderService.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Order>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd(); 
        }
    }
}