using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharAcademy.Controllers
{
    public class AcademicCalendarController : Controller
    {
        // GET: Academic
        public ActionResult PrimarySchool()
        {
            return View();
        }
        public ActionResult PrePrimarySchool()
        {
            return View();
        }
    }
}