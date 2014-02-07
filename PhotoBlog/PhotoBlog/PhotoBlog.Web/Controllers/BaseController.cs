using PhotoBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace PhotoBlog.Web.Controllers
{
    public class BaseController : ApiController
    {
        protected IUowData data;

        public BaseController(IUowData data)
        {
            this.data = data;
        }

        public BaseController()
            : this(new UowData())
        {

        }
	}
}