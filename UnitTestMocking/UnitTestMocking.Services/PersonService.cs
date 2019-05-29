using UnitTestMocking.Contracts;
using UnitTestMocking.Repositories;
using UnitTestMocking.Services.Interfaces;

namespace UnitTestMocking.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public void Create(Person person)
        {
            //Perform all business logic related to this service like validation etc.
            //Exception handling, logging etc.

            _personRepository.Create(person);
        }
    }
}