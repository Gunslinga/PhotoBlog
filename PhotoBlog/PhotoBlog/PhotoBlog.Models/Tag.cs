using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class Tag
    {
        private ICollection<BlogPost> posts;

        public Tag()
        {
            posts = new HashSet<BlogPost>();
        }

        public int Id { get; set; }

        public string Text { get; set; }

        public virtual ICollection<BlogPost> Posts
        {
            get { return posts; }
            set { posts = value; }
        }
    }
}
