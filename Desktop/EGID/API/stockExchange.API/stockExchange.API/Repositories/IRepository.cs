﻿using System;
using System.Linq.Expressions;

namespace stockExchange.API.Repositories
{
   
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();
            T GetById(int id);
            IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
            void Add(T entity);
            void Update(T entity);
            void Remove(T entity);
        }

    
   
}

