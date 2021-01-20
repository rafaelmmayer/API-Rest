using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Verbos.Controllers.Model.Services.Implematation
{
    public class PersonServiceImplematation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
              
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementId(),
                FirstName = "Rafael",
                LastName = "Mayer",
                Address = "Vinhedo - SP",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementId(),
                FirstName = "First Name" + i,
                LastName = "Last Name" + i,
                Address = "Address" + i,
                Gender = "Gender" + i
            };
        }

        private long IncrementId()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
