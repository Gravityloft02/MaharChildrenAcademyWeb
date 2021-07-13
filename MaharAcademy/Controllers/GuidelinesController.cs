using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharAcademy.Controllers
{
    public class GuidelinesController : Controller
    {
        // GET: Guidelines
        public ActionResult Parents()
        {
            return View();
        }
        public ActionResult Students()
        {
            return View();
        }
    }
}