﻿using System.Collections;
using System.Linq.Expressions;

namespace HomeworkPrac.Reopository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);  
        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
