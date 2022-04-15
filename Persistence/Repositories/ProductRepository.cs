using Application.Contract.Persistence;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class ProductRepository: Repository<Product>, IProductRepository 
    {
        public ProductRepository(E_CommerceDbContext e_CommerceDbContext):base(e_CommerceDbContext) 
        {

        }
    }
}
