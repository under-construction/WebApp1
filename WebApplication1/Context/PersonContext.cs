using Microsoft.EntityFrameworkCore;
using WebApp.Entities;

namespace WebApp.Context
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
        {

        }
        public DbSet<Person>? Person { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData
            (
                new Person { ID = 1, Name = "Ercument", Surname = "Kalkan", Age = 28 },
                new Person { ID = 2, Name = "Ezgi", Surname = "Gulsen", Age = 27 }
            );
        }
    }
}
