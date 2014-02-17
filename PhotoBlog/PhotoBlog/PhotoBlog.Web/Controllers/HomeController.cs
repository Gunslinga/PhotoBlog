using System;
using System.Linq;
using System.Web.Mvc;

namespace PhotoBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "admin", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }

        public ActionResult Image()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "image", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }
    }
}
