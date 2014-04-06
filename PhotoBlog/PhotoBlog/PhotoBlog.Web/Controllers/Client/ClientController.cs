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

            return View();
        }
        public ActionResult FirstGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/13";

            return View();
        }

        public ActionResult FirstGallerySub1()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/16";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory/16";

            return View();
        }

        public ActionResult FirstGallerySub2()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/17";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory/17";

            return View();
        }


        public ActionResult SecondGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/14";

            return View();
        }

        public ActionResult SecondGallerySub1()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/18";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory/18";

            return View();
        }

        public ActionResult SecondGallerySub2()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/19";
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/photosByCategory/19";

            return View();
        }

        public ActionResult ThirdGallery()
        {
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "Gallery" }) + "/categories/15";

            return View();
        }
	}
}