using Desafio.Models;
using Desafio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio.Controllers
{
    public class JugueteController : Controller
    {
        private JugueteRepository _repo;

        public JugueteController() {
            _repo = new JugueteRepository();
        }
        
        // GET: Juguete
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: Juguete/Details/5
        public ActionResult Details(int id)
        {
            var model = _repo.ObtenerTodos();
            return View(model.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: Juguete/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juguete/Create
        [HttpPost]
        public ActionResult Create(Juguete model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Create(model);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                //return View();
            }

            return View(model);
        }

        // GET: Juguete/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _repo.ObtenerTodos();
            return View(model.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Juguete/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Juguete model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _repo.Edit(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Juguete/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _repo.ObtenerTodos();
            return View(model.Where(x => x.Id == id).FirstOrDefault());
        }

        // POST: Juguete/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Juguete model)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    _repo.Remove(model);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
