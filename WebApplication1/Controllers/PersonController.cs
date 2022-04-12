using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public ICollection<Person> Get()
        {
            var context = new PersonContext();
            var persons = context.Persons.ToList();
            return persons;
        }

        [HttpPost]
        public void Post()
        {
            var context = new PersonContext();

            context.Add(new Person("Ivan", "Petrov", 12));
            context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteById(int id)
        {
            var rnd = new Random();
            var context = new PersonContext();
            context.Remove(context.Persons.Find(id));
            context.SaveChanges();
        }

        [HttpPut]
        public void SetNameById(int id, string name)
        {
            var rnd = new Random();
            var context = new PersonContext();
            context.Persons.First(p => p.Id == id).FirstName = name;
            context.SaveChanges();
        }
    }
}