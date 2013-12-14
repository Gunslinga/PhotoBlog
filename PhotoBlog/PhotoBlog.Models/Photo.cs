using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBlogSystem.Models
{
    public class Photo
    {
        private ICollection<Tag> tags;

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int AlbumId { get; set; }

        public ICollection<Tag> Tags
        {
            get { return tags; }
            set { tags = value; }
        }
        
    }
}
