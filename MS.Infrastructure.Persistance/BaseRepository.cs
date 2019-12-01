using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Framework.Domain;

namespace MS.Infrastructure.Persistance
{
    public class BaseRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
        private readonly MailContext _context;

        public BaseRepository(MailContext context)
        {
            _context = context;
        }

        public T Get(TKey id)
        {
            return _context.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            var query = _context.Set<T>().AsQueryable();
            query = query.Where(expression);
            return query.ToList();
        }

        public bool IsDuplicated(Expression<Func<T, bool>> expression)
        {
            var query = _context.Set<T>().AsQueryable();
            return query.Any(expression);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            var query = _context.Set<T>().AsQueryable();
            query = query.Where(expression);
            return query.Any();
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}