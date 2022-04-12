using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using HotChocolate;


namespace WebApplication1.GraphQL.Mutations
{
    public class PersonMutation
    {
        public Person CreatePerson([Service(ServiceKind.Synchronized)] PersonContext db, string firstName, string lastName, int age)
        {
            var person = new Person(firstName, lastName, age);

            db.Persons.Add(person);
            db.SaveChanges();
            return person;
        }
    }
}