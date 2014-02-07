﻿using System;
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

namespace PhotoBlog.Web.Controllers
{
    public class ClientController : BaseController
    {
        [ResponseType(typeof(IEnumerable<BlogPost>))]
        public IQueryable<BlogPost> GetBlogPosts()
        {
            return data.BlogPosts.All();
        }

        // GET api/Client/5
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult GetBlogPost(int id)
        {
            BlogPost blogpost = data.BlogPosts.GetById(id);
            if (blogpost == null)
            {
                return NotFound();
            }

            return Ok(blogpost);
        }

        private bool BlogPostExists(int id)
        {
            return data.BlogPosts.All().Count(e => e.Id == id) > 0;
        }
    }
}