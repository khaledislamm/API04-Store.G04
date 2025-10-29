using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Store.G04.persistence.Data.Contexts
{
    public class StoreDbContext : DbContext
    {
        // CLR
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
