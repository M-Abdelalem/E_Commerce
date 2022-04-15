using Application.Contract.Persistence;
using Persistence.Repositories;

namespace Persistence
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly E_CommerceDbContext _context;
        private readonly IProductRepository _productRepository;
        public UnitOfWork(E_CommerceDbContext context)
        {
            _context = context;   
        }
        public IProductRepository productRepository => _productRepository == null?new ProductRepository(_context) : _productRepository;

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
