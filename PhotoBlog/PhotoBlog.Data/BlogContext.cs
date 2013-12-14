using ConsoleBlogSystem.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace PhotoBlog.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Tag> Tag{ get; set; }
    }
}