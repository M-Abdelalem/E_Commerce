using Application.Contract.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ProductRepository: Repository<Product>, IProductRepository 
    {
        readonly E_CommerceDbContext _e_CommerceDbContext;
        public ProductRepository(E_CommerceDbContext e_CommerceDbContext):base(e_CommerceDbContext) 
        {
            _e_CommerceDbContext=e_CommerceDbContext;
        }

        public async  Task<IReadOnlyList<Product>> GetByBrandId(int? brandId)
        {
            return await _e_CommerceDbContext.products.Where(x => x.ProductBrandId == brandId).ToListAsync();
        }

     
    }
}
