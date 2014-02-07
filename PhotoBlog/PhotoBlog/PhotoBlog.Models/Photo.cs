using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class Photo
    {
        private ICollection<Tag> tags;

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public string Title { get; set; }

        [ScaffoldColumn(false)]
        public string Content { get; set; }

        public string Url { get; set; }

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
