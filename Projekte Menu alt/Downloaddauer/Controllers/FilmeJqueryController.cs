using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using Downloaddauer.Models;

namespace Downloaddauer.Controllers
{
    public class FilmeJqueryController : Controller
    {
        // GET: FilmeJquery
        public ActionResult Index()
        {
            DbConnector.GetFilme(DbConnector.Connect());
            DbConnector.GetPersons(DbConnector.Connect());
            DbConnector.GetBesetzung(DbConnector.Connect());

            return View();
        }


        [HttpGet]
        public ActionResult WebPost()
        {

            return View();
        }



        [HttpPost]
        public string WebPost(string Eingabe)
        {
            DbConnector.GetFilme(DbConnector.Connect());

            string filmchen = "";


            for (int i = 0; i < Film.filme.Count; i++)
            {
                if (Film.filme[i].Titel.ToLower().Contains(Eingabe.ToLower()) )
                {
                    filmchen += Film.filme[i].Titel + "\n";
                }
            }

            return filmchen;
        }

    }
}