
namespace Application.Contract.Persistence
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }
        IProductTypeRepository productTypeRepository { get; }

        IProductBrandRepository productBrandRepository { get; }

        Task SaveChanges();

    }
}
