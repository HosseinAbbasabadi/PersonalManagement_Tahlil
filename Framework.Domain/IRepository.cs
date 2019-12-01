using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Framework.Domain
{
    public interface IRepository<in TKey, T>
    {
        T Get(TKey id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression); // (x=>x.id == id && x.name == name)
        bool IsDuplicated(Expression<Func<T, bool>> expression);
        bool Exists(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void SaveChanges();
    }
}