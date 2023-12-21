using Microsoft.EntityFrameworkCore;
using WebApp.Entities;

namespace WebApp.IRepository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<IQueryable<Person>> GetPeopleOlderThan(int age);
    }
}
