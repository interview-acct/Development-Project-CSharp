using Interview.Database.DAL_Objects;
using Microsoft.EntityFrameworkCore;

namespace Interview.Database.Contexts
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Attribute> Attributes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .HasMany<Category>();
            //modelBuilder.Entity<Product>()
            //    .HasMany<Attribute>();

            modelBuilder.Entity<Category>()
                .HasMany<Product>();

            modelBuilder.Entity<Attribute>()
                .HasMany<Product>();
        }
    }
}
