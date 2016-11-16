using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // Get: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}