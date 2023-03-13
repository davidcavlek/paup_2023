using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paup_2023.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public ActionResult Index()
        {
            ViewBag.Lokacija = "Medimursko veleuciliste u cakovcu";
            return View();
        }
        public ActionResult Druga()
        {
            ViewBag.Ustanova = "Medimursko veleuciliste";
            ViewData["Lokacija"] = "Čakovec";
            return View();
        }

        public ActionResult Treca(string poruka, int broj=1)
        {
            ViewBag.Poruka = poruka;
            ViewBag.Broj = broj;
            return View();
        }
        public ActionResult Student()
        {
            ViewBag.Ime = "Joško";
            ViewBag.Prezime = "Lokas";
            ViewBag.GodinaRod = "1975";
            return View();
        }
        public string VratiVrijeme()
        {
            return DateTime.Now.ToString();
        }
    }
}