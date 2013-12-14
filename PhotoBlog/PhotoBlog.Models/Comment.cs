using System;
using System.Linq;

namespace ConsoleBlogSystem.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public virtual BlogPost Post { get; set; }
    }
}
