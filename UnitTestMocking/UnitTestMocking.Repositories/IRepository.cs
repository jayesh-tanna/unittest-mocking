namespace UnitTestMocking.Repositories
{
    public interface IRepository<T> where T : new()
    {
        void Create(T item);
    }
}