using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldControler : Controller
    {
        // GET: HelloWorldControler
        public ActionResult Index()
        {
            return View();
        }
    }
}