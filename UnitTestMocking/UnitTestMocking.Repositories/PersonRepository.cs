using UnitTestMocking.Contracts;

namespace UnitTestMocking.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        public void Create(Person item)
        {
            throw new System.NotImplementedException();
        }
    }
}