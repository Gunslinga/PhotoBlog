using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBlogSystem.Models
{
    public class BlogPost
    {
        private ICollection<Comment> answers;
        private ICollection<Tag> tags;

        public BlogPost()
        {
            answers = new HashSet<Comment>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public ICollection<Comment> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public ICollection<Tag> Tags
        {
            get { return tags; }
            set { tags = value; }
        }
    }
}
