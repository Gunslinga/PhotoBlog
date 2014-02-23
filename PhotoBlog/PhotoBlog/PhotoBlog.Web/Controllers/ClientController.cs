using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoBlog.Web.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult BlogPosts()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "client" });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();
            ViewBag.BlogPostsUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "blogPost" });
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "category" });

            return View();
        }

        public ActionResult Gallery()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "client" });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();
            ViewBag.GalleryUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "gallery" });
            ViewBag.CategoriesUrl = Url.HttpRouteUrl("DefaultApi", new { controller = "category" });

            return View();
        }
	}
}