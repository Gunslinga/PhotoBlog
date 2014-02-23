using PhotoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PhotoBlog.Web.Controllers
{
    public class GalleryController : BaseController
    {
        [ResponseType(typeof(IEnumerable<Photo>))]
        public IEnumerable<Photo> GetPhotos()
        {
            return data.Photos.All();
        }
    }
}
