
namespace Application.Contract.Persistence
{
    public interface IUnitOfWork
    {
        IProductRepository productRepository { get; }   
        Task SaveChanges();

    }
}
