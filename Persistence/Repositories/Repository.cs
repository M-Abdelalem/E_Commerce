using Application.Contract.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class Repository<T> : Irepository<T> where T : class
    {
        readonly E_CommerceDbContext _context;
        public Repository(E_CommerceDbContext context)
        {
            _context = context; 
        
        }
        public  async Task<T> Create(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return  item;
        }

        public async Task Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T item)
        {
             _context.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}