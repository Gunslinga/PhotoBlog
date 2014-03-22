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

        public string ThumbUrl { get; set; }

        public int GalleryCategoryId { get; set; }

        public virtual PhotoCategory Category { get; set; }

        public ICollection<Tag> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

    }
}
