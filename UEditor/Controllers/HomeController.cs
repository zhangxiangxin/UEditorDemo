using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UEditor.Models;

namespace UEditor.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(Post p)
        {
            if (ModelState.IsValid)
            {
                ViewData["c"] = p.Content;
                return PartialView("Result");
            }
            return View(p);
        }

    }
}
