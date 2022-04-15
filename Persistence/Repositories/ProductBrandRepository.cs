using Application.Contract.Persistence;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class ProductBrandRepository : Repository<ProductBrand>, IProductBrandRepository
    {
        public ProductBrandRepository(E_CommerceDbContext e_CommerceDbContext):base(e_CommerceDbContext) 
        {

        }
    }
}
