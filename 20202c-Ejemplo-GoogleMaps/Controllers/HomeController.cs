using _20202c_Ejemplo_GoogleMaps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20202c_Ejemplo_GoogleMaps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VerMapa()
        {
            List<MarcadorGoogle> marcadores = new List<MarcadorGoogle>();
            marcadores.Add(new MarcadorGoogle() { Titulo = "Buenos Aires", Lat = -34.6158037, Lng = -58.5033386 });
            marcadores.Add(new MarcadorGoogle() { Titulo = "San Pablo", Lat = -34.8208575, Lng = -56.3765241 });
            marcadores.Add(new MarcadorGoogle() { Titulo = "Montevideo", Lat = -23.6821604, Lng = -46.8754923 });
            marcadores.Add(new MarcadorGoogle() { Titulo = "Bogota", Lat = 4.6482837, Lng = -74.247894 });

            return View(marcadores);
        }
    }
}