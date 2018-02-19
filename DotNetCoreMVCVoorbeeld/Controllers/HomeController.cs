using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMVCVoorbeeld.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "asperge", "rode kool", "wortel", "spruiten", "spinazie" };
        public ViewResult index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeiemiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;

            if (string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groenten is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }

            return View();
        }
    }
}