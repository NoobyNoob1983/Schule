using Downloaddauer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Downloaddauer.Controllers
{
    public class PalindromController : Controller
    {
        // GET: Palindrom
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Text)
        {
            Palindrom p = new Palindrom();
            p.Text = Text;
            return View(p);
        }
    }
}