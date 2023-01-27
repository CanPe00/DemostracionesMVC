using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private EscuelaDBMVCContext context;

        public AulaController(EscuelaDBMVCContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Aula> aulas = context.Aulas.ToList();
            return View(aulas);
        }

        public IActionResult Create()
        {
            Aula aula = new Aula();
            return View(aula);
        }

        [HttpPost]
        public IActionResult Create(Aula aula)
        {
            if(ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index");   
            }
            return View(aula);
        }

        public IActionResult Details(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            return View(aula);
        }

        public IActionResult Edit(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            return View(aula);

        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditConfirmed(Aula aula)
        {
            if (ModelState.IsValid) 
            {
                context.Entry(aula).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aula);
        }

        public IActionResult Delete(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            return View(aula);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            context.Aulas.Remove(aula);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        private Aula TraerUna(int id)
        {
            return context.Aulas.Find(id);
        }
    }
}
