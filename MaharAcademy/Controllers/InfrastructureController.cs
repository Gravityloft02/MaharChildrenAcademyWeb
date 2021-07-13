using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaharAcademy.Controllers
{
    public class InfrastructureController : Controller
    {
        // GET: Infrastructure
        public ActionResult Classroom()
        {
            return View();
        }
        public ActionResult ComputerLab()
        {
            return View();
        }
        public ActionResult Playground()
        {
            return View();
        }
        public ActionResult Library()
        {
            return View();
        }
        public ActionResult Infirmary()
        {
            return View();
        }
    }
}