using ConsoleBlogSystem.Models;
using PhotoBlog.Data.Migrations;
using System;
using System.Data.Entity;
using System.Linq;

namespace PhotoBlog.Data
{
    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogContext, Configuration>());
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}