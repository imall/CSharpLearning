using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {

        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }


        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T employee)
        {
            _dbSet.Add(employee);
        }

        public void Remove(T employee)
        {
            _dbSet.Remove(employee);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }


}
