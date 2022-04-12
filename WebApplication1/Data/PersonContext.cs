using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class PersonContext : DbContext

    {
        public PersonContext()
        {
        }

        public PersonContext(DbContextOptions<PersonContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=PersonContext;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Person> Persons { get; set; }
    }
}