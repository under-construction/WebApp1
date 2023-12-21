using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Repository
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        PersonContext _context;

        public CurrencyRepository(PersonContext context) : base(context)
        {
            _context = context;    
        }
    }
}
