using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleBlogSystem.Models
{
    public class Album
    {
        private ICollection<Photo> photos;

        public Album()
        {
            photos = new HashSet<Photo>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int PhotoId { get; set; }

        public virtual ICollection<Photo> Photos
        {
            get { return photos; }
            set { photos = value; }
        }
    }
}
