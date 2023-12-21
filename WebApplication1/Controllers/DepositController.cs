using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Context;
using WebApp.Entities;
using WebApp.IRepository;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly IRepository<Deposit> _repository;

        public DepositController(IRepository<Deposit> repository)
        {
            _repository = repository;
        }

        // GET: api/People
        [HttpGet]
        public async Task<IEnumerable<Deposit>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<Deposit?> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        // PUT: api/People/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task Update(int id, Person person)
        //{
            //if (id != person.ID)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(person).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!PersonExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
        //}

        // POST: api/People
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<Deposit> Insert(Deposit deposit)
        {
          return await _repository.InsertAsync(deposit);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
