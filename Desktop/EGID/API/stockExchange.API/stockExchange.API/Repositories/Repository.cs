using Microsoft.EntityFrameworkCore;
using stockExchange.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace stockExchange.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly StockDBContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(StockDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

    }
}
