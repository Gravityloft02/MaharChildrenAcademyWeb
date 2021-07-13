using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharAcademy.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Photos()
        {
            return View();
        }
        public ActionResult Videos()
        {
            return View();
        }
    }
}