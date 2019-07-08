using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBFirst_Mitarbeiter.Models;

namespace DBFirst_Mitarbeiter.Controllers
{


    public class HomeController : Controller
    {


        public readonly TeachSQLContext _context;


        public HomeController(TeachSQLContext context)
        {
            this._context = context;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
