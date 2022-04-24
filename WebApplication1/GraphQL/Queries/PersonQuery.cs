using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using HotChocolate;


namespace WebApplication1.GraphQL.Queries
{
    public class PersonQuery
    {
        private readonly PersonContext _db;

        public PersonQuery([FromServices]PersonContext db)
        {
            _db = db;
        }
        public List<Person> Persons()
        {
            var persons = _db.Persons.ToList();
            return persons;
        }
    }
}