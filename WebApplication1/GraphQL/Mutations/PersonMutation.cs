using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using HotChocolate;


namespace WebApplication1.GraphQL.Mutations
{
    public class PersonMutation
    {
        private readonly PersonContext _db;

        public PersonMutation(PersonContext db)
        {
            _db = db;
        }

        public Person CreatePerson(string firstName,
            string lastName, int age)
        {
            var person = new Person(firstName, lastName, age);

            _db.Persons.Add(person);
            return person;
        }
    }
}