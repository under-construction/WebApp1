using Microsoft.EntityFrameworkCore;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Repository
{
    public class DepositTypeRepository : Repository<DepositType>, IDepositTypeRepository
    {
        PersonContext _context;

        public DepositTypeRepository(PersonContext context) : base(context)
        {
            _context = context;    
        }
    }
}
