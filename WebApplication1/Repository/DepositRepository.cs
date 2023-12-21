using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Repository
{
    public class DepositRepository : Repository<Deposit>, IDepositRepository
    {
        PersonContext _context;

        public DepositRepository(PersonContext context) : base(context)
        {
            _context = context;    
        }
    }
}
