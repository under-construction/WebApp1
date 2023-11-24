using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;

namespace WebApp.Repository
{
    public class PersonRepository : IRepository<Person>
    {
        PersonContext _context;

        public PersonRepository(PersonContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.Set<Person>().AsNoTracking().ToListAsync();
        }

        public async Task<Person> InsertAsync(Person entity)
        {
            await _context.Set<Person>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            Person? entity = await _context.Set<Person>().FindAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Object is null.");
            }

            _context.Set<Person>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Person> GetById(int id)
        {
            Person? entity = await _context.Set<Person>().FindAsync(id);

            if (entity == null)
            {
                throw new NullReferenceException("Object is null.");
            }

            return entity;
        }

        public Task<Person> UpdateAsync(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
