using CRUD.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Server.Respository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DataContext _context = null;
        private DbSet<T> table = null;
      
        public GenericRepository(DataContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> set = table;
            return set;
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }

        public async Task AddAsync(T entity)
        {
            await table.AddAsync(entity);
            _context.SaveChanges();
        }
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
      
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
