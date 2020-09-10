using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NApuestas.Controllers
{
    public class DiagramasController : Controller
    {
        // GET: DiagramasController
        public ActionResult MostrarDiagramas()
        {
            return View();
        }

        // GET: DiagramasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DiagramasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiagramasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiagramasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiagramasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiagramasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiagramasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
