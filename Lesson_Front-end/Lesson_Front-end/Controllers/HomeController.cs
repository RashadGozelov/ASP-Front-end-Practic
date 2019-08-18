using Lesson_Front_end.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_Front_end.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(Images.GetImages());
        }
    }
}