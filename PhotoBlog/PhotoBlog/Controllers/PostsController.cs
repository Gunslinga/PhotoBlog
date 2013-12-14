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
using ConsoleBlogSystem.Models;
using PhotoBlog.Data;

namespace PhotoBlog.Controllers
{
    public class PostsController : ApiController
    {
        private static BlogContext db = new BlogContext();

        // GET api/Posts
        public IQueryable<BlogPost> GetBlogPosts()
         {
            AddDummyPost();
            return db.BlogPosts;
        }


        private void AddDummyPost()
        {
            var post = new BlogPost();
            post.Title = "kur";
            post.Content = "Vanio";

            db.BlogPosts.Add(post);
            db.SaveChanges();
        }

        // GET api/Posts/5
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult GetBlogPost(int id)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            if (blogpost == null)
            {
                return NotFound();
            }

            return Ok(blogpost);
        }

        // PUT api/Posts/5
        public IHttpActionResult PutBlogPost(int id, BlogPost blogpost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != blogpost.Id)
            {
                return BadRequest();
            }

            db.Entry(blogpost).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
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

        // POST api/Posts
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult PostBlogPost(BlogPost blogpost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BlogPosts.Add(blogpost);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = blogpost.Id }, blogpost);
        }

        // DELETE api/Posts/5
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult DeleteBlogPost(int id)
        {
            BlogPost blogpost = db.BlogPosts.Find(id);
            if (blogpost == null)
            {
                return NotFound();
            }

            db.BlogPosts.Remove(blogpost);
            db.SaveChanges();

            return Ok(blogpost);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BlogPostExists(int id)
        {
            return db.BlogPosts.Count(e => e.Id == id) > 0;
        }
    }
}