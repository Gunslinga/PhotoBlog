using System;
using System.Linq;
using System.Web.Mvc;

namespace PhotoBlog.Web.Controllers.Admin
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult BlogPostsAdmin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "blogPostAdmin", });
            string getUri = Url.HttpRouteUrl("DefaultApi", new { controller = "blogPost", });

            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();           
            ViewBag.GetUrl = new Uri(Request.Url, getUri).AbsoluteUri.ToString() + "/posts";

            return View();
        }
        public ActionResult GalleryAdmin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "GalleryAdmin", });
            string getUri = Url.HttpRouteUrl("DefaultApi", new { controller = "gallery", });

            ViewBag.GalleryUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();
            ViewBag.GetUrl = new Uri(Request.Url, getUri).AbsoluteUri.ToString() + "/photos";
            return View();
        }
    }
}
