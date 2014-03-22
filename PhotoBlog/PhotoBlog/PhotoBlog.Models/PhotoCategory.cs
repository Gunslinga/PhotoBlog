using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBlog.Models
{
    public class PhotoCategory
    {
        public static int All = 3;

        private ICollection<Photo> images;

        public PhotoCategory()
        { }

        public int Id { get; set; }

        public string Name { get; set; }

        public int? PhotoCategoryId { get; set; }

        public virtual PhotoCategory Parent { get; set; }

        public virtual ICollection<Photo> Images
        {
            get { return images; }
            set { images = value; }
        }
    }
}
