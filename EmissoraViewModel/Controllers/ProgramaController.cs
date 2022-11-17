using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmissoraViewModel.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmissoraViewModel.Controllers
{
    public class ProgramaController : Controller
    {
        public readonly ProgramaViewModel vm;
        public ProgramaController(ProgramaViewModel _vm)
        {
            vm = _vm;
        }

        // GET: Programa
        public ActionResult Index()
        {
            return View(vm.BuscarProgramas());
        }


        // GET: Programa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Programa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Programa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Programa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Programa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Programa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Programa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}