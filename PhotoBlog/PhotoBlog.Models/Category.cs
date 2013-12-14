using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBlogSystem.Models
{
    public class Category
    {
        private ICollection<BlogPost> posts;

        public Category()
        {
            posts = new HashSet<BlogPost>();
        }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Parent { get; set; }

        public virtual ICollection<BlogPost> Posts
        {
            get { return posts; }
            set { posts = value; }
        }

    }
}
