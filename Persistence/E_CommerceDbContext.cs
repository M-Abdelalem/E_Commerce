using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class E_CommerceDbContext:DbContext
    {
        public E_CommerceDbContext(DbContextOptions<E_CommerceDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(E_CommerceDbContext).Assembly);
        }
        public DbSet<Product>products { get; set; }
        public DbSet<ProductBrand>  productBrands { get; set; }
        public DbSet<ProductType> productTypes { get; set; }

    }
}
