using System;
using System.Collections.Generic;
using System.Linq;

namespace PhotoBlog.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        IEnumerable<T> Where(Func<T, bool> predicate);

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Detach(T entity);
    }
}
