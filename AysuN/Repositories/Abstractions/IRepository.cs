namespace AysuN.Repositories.Abstractions
{
    public interface IRepository<T>
    {
       List<T> GetAll();
        T GetById(int id);
        void Update(int id,T entity);
        void DeleteById(int id);
        void Create(T entity);
    }
}
