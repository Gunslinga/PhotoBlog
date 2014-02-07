using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
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

        public int? PhotoId { get; set; }

        public virtual ICollection<Photo> Photos
        {
            get { return photos; }
            set { photos = value; }
        }
    }
}
