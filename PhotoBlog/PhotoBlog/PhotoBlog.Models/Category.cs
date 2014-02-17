using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class Category
    {
        public static int All = 3;

        private ICollection<BlogPost> posts;

        public Category()
        {
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
