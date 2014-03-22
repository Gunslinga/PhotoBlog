using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using PhotoBlog.Models;

namespace PhotoBlog.Web.Controllers.Client
{
    [RoutePrefix("api/blogPost")]
    public class BlogPostController : BaseController
    {
        [Route("posts")]
        [ActionName("posts")]
        [ResponseType(typeof(IEnumerable<BlogPost>))]
        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return data.BlogPosts.All();
        }

        [Route("categories")]
        [ActionName("categories")]
        [ResponseType(typeof(IEnumerable<BlogPostCategory>))]
        public IEnumerable<BlogPostCategory> GetCategories()
        {
            return data.BlogPostCategories.All();
        }

        [Route("categories/{categoryId:int}")]
        [ResponseType(typeof(IEnumerable<BlogPost>))]
        public IEnumerable<BlogPost> GetBlogPostsByCategory(int categoryId)
        {
            if (categoryId == BlogPostCategory.All)
            {
                return GetBlogPosts();
            }
            else
            {

                return data.BlogPosts.All().Where(p => p.BlogPostCategoryId == categoryId);
            }
        }

        private bool BlogPostExists(int id)
        {
            return data.BlogPosts.All().Count(e => e.Id == id) > 0;
        }
    }
}