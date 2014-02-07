using PhotoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Data
{
    public interface IUowData : IDisposable
    {
        IRepository<BlogPost> BlogPosts { get; }

        IRepository<Album> Albums { get; }

        IRepository<Tag> Tags { get; }

        IRepository<Category> Categorys { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Photo> Photos { get; }
        int SaveChanges();
    }
}
