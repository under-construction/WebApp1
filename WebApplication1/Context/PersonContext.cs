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
        public DbSet<Deposit>? Deposits { get; set; }
        public DbSet<DepositType>? DepositTypes { get; set; }
        public DbSet<Currency>? Currencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Navigation(p => p.Deposits).AutoInclude();
            modelBuilder.Entity<DepositType>().Navigation(d => d.Deposits).AutoInclude();
            modelBuilder.Entity<Currency>().Navigation(c => c.Deposits).AutoInclude();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                ((BaseEntity)entry.Entity).UpdatedDate = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).CreatedDate = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
