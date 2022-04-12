using System.Collections.Generic;
using System.Linq;
using GraphQL.Types;
using HotChocolate;


namespace WebApplication1.GraphQL.Queries
{
    public class PersonQuery
    {
        public List<Person> GetPersons([Service(ServiceKind.Synchronized)] PersonContext db)
        {
            var persons = db.Persons.ToList();
            return persons;
        }
    }
}