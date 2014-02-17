using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using PhotoBlog.Models;

namespace PhotoBlog.Web.Controllers
{
    [RoutePrefix("api/blogPost")]
    public class BlogPostController : BaseController
    {
        [Route("")]
        [ResponseType(typeof(IEnumerable<BlogPost>))]
        public IEnumerable<BlogPost> GetBlogPosts()
        {
            return data.BlogPosts.All();
        }

        [Route("{categoryId:int}")]
        [ResponseType(typeof(IEnumerable<BlogPost>))]
        public IEnumerable<BlogPost> GetBlogPostsByCategory(int categoryId)
        {
            if (categoryId == Category.All)
            {
                return GetBlogPosts();
            }
            else
            {

                return data.BlogPosts.All().Where(p => p.CategoryId == categoryId);
            }
        }

        // GET api/Client/5
        //[ResponseType(typeof(BlogPost))]
        //public IHttpActionResult GetBlogPost(int id)
        //{
        //    BlogPost blogpost = data.BlogPosts.GetById(id);
        //    if (blogpost == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(blogpost);
        //}

        private bool BlogPostExists(int id)
        {
            return data.BlogPosts.All().Count(e => e.Id == id) > 0;
        }
    }
}