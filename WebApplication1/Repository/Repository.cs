using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        PersonContext _context;

        public Repository(PersonContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> InsertAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            T? entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Object is null.");
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            T? entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Object is null.");
            }

            return entity;
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
