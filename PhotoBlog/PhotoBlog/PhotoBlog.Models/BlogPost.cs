using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class BlogPost
    {
        private ICollection<Comment> comments;
        private ICollection<Tag> tags;

        public BlogPost()
        {
            comments = new HashSet<Comment>();
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string Title { get; set; }

        public int? BlogPostCategoryId { get; set; }

        //[ScaffoldColumn(false)]
        //public virtual Category Category { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public ICollection<Comment> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public ICollection<Tag> Tags
        {
            get { return tags; }
            set { tags = value; }
        }
    }
}
