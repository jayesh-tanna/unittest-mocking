using UnitTestMocking.Contracts;

namespace UnitTestMocking.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        public virtual void Create(Person item)
        {
            //Create record in database instead of throwing an exception. this is just for an example. 
            throw new System.NotImplementedException();
        }
    }
}