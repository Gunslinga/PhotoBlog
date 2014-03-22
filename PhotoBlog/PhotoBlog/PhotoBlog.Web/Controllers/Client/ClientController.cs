using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoBlog.Web.Controllers.Client
{
    public class ClientController : Controller
    {
        public ActionResult BlogPosts()
        {
            ViewBag.BlogPostsUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "blogPost" }) + "/posts";
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "blogPost" }) + "/categories";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/12";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory";

            return View();
        }
        public ActionResult FirstGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/13";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory";

            return View();
        }

        public ActionResult SecondGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/14";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory";

            return View();
        }

        public ActionResult ThirdGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/15";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory";

            return View();
        }
	}
}