namespace CRUD.Server.Respository
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object id);
        Task AddAsync(T entity);
        void Update(T obj);
        void Save();
        Task DeleteAsync(T entity);
    }

}
