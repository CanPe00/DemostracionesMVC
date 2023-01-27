using Microsoft.AspNetCore.Mvc;
using OperaWebSite.Data;
using OperaWebSite.Models;
using System.Linq;

namespace OperaWebSite.Controllers
{
    public class OperaController : Controller
    {
        private readonly DBOperaContext context;

        public OperaController(DBOperaContext context)
        {
            this.context = context;
        }


        //GET /Opera
        //GET /Opera/index
        public IActionResult Index()
        {
            //Lista de Operas
            var operas = context.Operas.ToList();
            //Enviar la lista a la view
            //return View("Index", operas);
            return View(operas);
        }

        // GET Opera/Create
        [HttpGet]
        public IActionResult Create()
        {
            Opera opera = new Opera();
            return View("Create", opera); //DEVOLVER AL CLEINTE HTML(VISTA)
        }

        //POST Opera/Create
        [HttpPost]
        public IActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        //GET Opera/Delete/1
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            Opera opera = TraerUna(id);
            if(opera==null)
            {
                return NotFound();
            }
            return View(opera);
        }


        //POST Opera/Delete/1
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Opera opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            context.Operas.Remove(opera);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        //GET Opera/Details/1
        public IActionResult Details(int id)
        {
            Opera opera = TraerUna(id);
            if (opera == null)
            {
                return NotFound();
            }
            return View(opera);
        }

        //METODOS PRIVADOS
        private Opera TraerUna(int id)
        {
            return context.Operas.Find(id);
        }


    }
}
