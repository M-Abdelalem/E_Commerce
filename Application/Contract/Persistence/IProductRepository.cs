using Domain.Entities;


namespace Application.Contract.Persistence
{
    public interface IProductRepository : Irepository<Product>
    {
         Task<IReadOnlyList<Product>> GetByBrandId(int productTypeId);

    }
}
