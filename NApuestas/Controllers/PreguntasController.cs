using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NApuestas.Controllers
{
    public class PreguntasController : Controller
    {
        // GET: PreguntasController
        LogicaPreguntas MilogicaPreguntas = new LogicaPreguntas();
        public ActionResult ListarPreguntasConAlternativas()
        {

            return View(MilogicaPreguntas.ObtenerPreguntasAlternativas()) ;
        }

        // GET: PreguntasController/Details/5
        [HttpPost]
        public ActionResult MiLogicaPreguntas(string )
        {
            return View();
        }

        // GET: PreguntasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PreguntasController/Create
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

        // GET: PreguntasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PreguntasController/Edit/5
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

        // GET: PreguntasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PreguntasController/Delete/5
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
