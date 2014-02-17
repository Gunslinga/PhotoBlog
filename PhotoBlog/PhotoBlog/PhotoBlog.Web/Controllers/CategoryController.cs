using PhotoBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Description;

namespace PhotoBlog.Web.Controllers
{
    public class CategoryController : BaseController
    {

        [ResponseType(typeof(IEnumerable<Category>))]
        public IEnumerable<Category> GetCategories()
        {
            return data.Categorys.All();
        }
    }
}
