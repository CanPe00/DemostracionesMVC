using Microsoft.AspNetCore.Mvc;
using System;

namespace ClinicaWebSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Clinicas";
            ViewBag.Fecha = DateTime.Today.ToString();
            return View();
        }
    }
}
