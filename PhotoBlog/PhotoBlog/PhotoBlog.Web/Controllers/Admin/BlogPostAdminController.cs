using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PhotoBlog.Models;
using PhotoBlog.Data;

namespace PhotoBlog.Web.Controllers.Admin
{
    public class BlogPostAdminController : BaseController
    {
        // PUT api/Admin/5
        public IHttpActionResult PutBlogPost(int id, BlogPost blogPost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blogPost.Id)
            {
                return BadRequest();
            }

            data.BlogPosts.Update(blogPost);

            try
            {
                data.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlogPostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Admin
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult PostBlogPost(BlogPost blogpost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.BlogPosts.Add(blogpost);
            data.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = blogpost.Id }, blogpost);
        }

        // DELETE api/Admin/5
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult DeleteBlogPost(int id)
        {
            BlogPost blogpost = data.BlogPosts.GetById(id);
            if (blogpost == null)
            {
                return NotFound();
            }

            data.BlogPosts.Delete(blogpost);
            data.SaveChanges();

            return Ok(blogpost);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                data.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BlogPostExists(int id)
        {
            return data.BlogPosts.All().Count(e => e.Id == id) > 0;
        }
    }
}