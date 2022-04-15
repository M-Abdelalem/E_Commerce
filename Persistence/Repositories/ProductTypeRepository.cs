using Application.Contract.Persistence;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(E_CommerceDbContext e_CommerceDbContext):base(e_CommerceDbContext) 
        {

        }
    }
}
