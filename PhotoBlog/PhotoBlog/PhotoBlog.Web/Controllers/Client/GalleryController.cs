using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using PhotoBlog.Models;

namespace PhotoBlog.Web.Controllers.Client
{
    [RoutePrefix("api/gallery")]
    public class GalleryController : BaseController
    {
        [Route("photos")]
        [ActionName("photos")]
        [ResponseType(typeof(IEnumerable<Photo>))]
        public IEnumerable<Photo> GetPhotos()
        {
            return data.Photos.All();
        }

        [Route("categories/{categoryId:int}")]
        [ActionName("categories/{categoryId:int}")]
        [ResponseType(typeof(IEnumerable<PhotoCategory>))]
        public IEnumerable<PhotoCategory> GetCategories(int categoryId)
        {
            return data.PhotoCategories.All().Where(p => p.PhotoCategoryId == categoryId);
        }

        [Route("photosByCategory/{categoryId:int}")]
        [ResponseType(typeof(IEnumerable<Photo>))]
        public IEnumerable<Photo> GetPhotoByCategory(int categoryId)
        {
            return data.Photos.All().Where(p => p.GalleryCategoryId == categoryId);
        }

        private bool PhotoExists(int id)
        {
            return data.Photos.All().Count(e => e.Id == id) > 0;
        }
    }
}