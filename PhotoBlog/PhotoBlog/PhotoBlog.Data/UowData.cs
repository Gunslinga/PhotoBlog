using PhotoBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Data
{
    public class UowData : IUowData
    {
        private readonly DbContext context;
        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UowData()
            : this(new BlogContext())
        {
        }

        public UowData(DbContext context)
        {
            this.context = context;
        }


        public IRepository<BlogPost> BlogPosts
        {
            get { return GetRepository<BlogPost>(); }
        }

        public IRepository<Album> Albums
        {
            get { return GetRepository<Album>(); }
        }

        public IRepository<Tag> Tags
        {
            get { return GetRepository<Tag>(); }
        }

        public IRepository<Category> Categorys
        {
            get { return GetRepository<Category>(); }
        }

        public IRepository<Comment> Comments
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Photo> Photos
        {
            get { return GetRepository<Photo>(); }
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                repositories.Add(typeof(T), Activator.CreateInstance(type, context));
            }

            return (IRepository<T>)repositories[typeof(T)];
        }
    }
}
