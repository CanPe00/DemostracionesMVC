using ClinicaWebSite.Data;
using ClinicaWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaWebSite.Controllers
{
    public class MedicoController : Controller
    {
        private DBClinicaMVCContext context;

        public MedicoController(DBClinicaMVCContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Medico> medicos = context.Medicos.ToList();
            return View(medicos);
        }

        public IActionResult Create()
        {
            Medico medico = new Medico();
            return View(medico);
        }

        [HttpPost]
        public IActionResult Create(Medico medico) 
        {
            if(ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        public IActionResult Delete(int id) 
        { 
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            context.Medicos.Remove(medico);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id) 
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        public IActionResult Edit(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditConfirmed(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Entry(medico).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

    }
}
