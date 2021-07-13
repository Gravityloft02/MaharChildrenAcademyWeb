using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharAcademy.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult BriefHistory()
        {
            return View();
        }
        public ActionResult Vision()
        {
            return View();
        }
        public ActionResult ThePrincipal()
        {
            return View();
        }
    }
}