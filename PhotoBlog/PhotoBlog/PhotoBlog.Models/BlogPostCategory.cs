using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class BlogPostCategory
    {
        public static int All = 6;

        private ICollection<BlogPost> posts;

        public BlogPostCategory()
        { }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? BlogPostCategoryId { get; set; }

        public virtual BlogPostCategory Parent { get; set; }

        public virtual ICollection<BlogPost> Posts
        {
            get { return posts; }
            set { posts = value; }
        }
    }
}
