using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        PersonContext _context;

        public PersonRepository(PersonContext context) : base(context)
        {
            _context = context;    
        }

        public Task<IQueryable<Person>> GetPeopleOlderThan(int age)
        {
            return (Task<IQueryable<Person>>)_context.Set<Person>().Where(i => i.Age > age);
        }
    }
}
