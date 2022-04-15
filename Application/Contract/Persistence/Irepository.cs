
namespace Application.Contract.Persistence
{
    public interface Irepository<T> where T : class
    {
       Task<IReadOnlyList<T>> GetAll();
        Task<T> Create(T item);
        Task<T> Update(T item);
        Task Delete(int Id);
        Task<T> GetById(int id);

    }
}
