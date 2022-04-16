using Domain.Base;
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
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			SetProperties();
			return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override int SaveChanges()
        {
			SetProperties();
			return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
		{
			SetProperties();

			return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			SetProperties();

			return base.SaveChangesAsync(cancellationToken);
        }


        private void SetProperties()
		{
			foreach (var entity in ChangeTracker.Entries().Where(p => p.State == EntityState.Added))
			{
				var created = entity.Entity as IDateCreated;
				if (created != null)
				{
					created.CreationDate = DateTime.Now;
				}
			}
		}


		public DbSet<Product>products { get; set; }
        public DbSet<ProductBrand>  productBrands { get; set; }
        public DbSet<ProductType> productTypes { get; set; }

    }
}
