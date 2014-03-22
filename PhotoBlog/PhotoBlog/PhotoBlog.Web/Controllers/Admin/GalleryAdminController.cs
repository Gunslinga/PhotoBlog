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
    public class GalleryAdminController : BaseController
    {

        // PUT api/Admin/5
        public IHttpActionResult PutPhoto(int id, Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != photo.Id)
            {
                return BadRequest();
            }

            data.Photos.Update(photo);

            try
            {
                data.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoExists(id))
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
        public IHttpActionResult PostPhoto(Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            data.Photos.Add(photo);
            data.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = photo.Id }, photo);
        }

        // DELETE api/Admin/5
        [ResponseType(typeof(BlogPost))]
        public IHttpActionResult DeletePhoto(int id)
        {
            Photo photo = data.Photos.GetById(id);
            if (photo == null)
            {
                return NotFound();
            }

            data.Photos.Delete(photo);
            data.SaveChanges();

            return Ok(photo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                data.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PhotoExists(int id)
        {
            return data.Photos.All().Count(e => e.Id == id) > 0;
        }
    }
}
