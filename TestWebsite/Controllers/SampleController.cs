using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebsite.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Sample()
        {
            return View();
        }
    }
}