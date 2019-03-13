using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class MatriculaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Matricula
        public ActionResult Index()
        {
            return View(db.Matriculas.ToList());
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matricula/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Matricula/Create
        [HttpPost]
        public ActionResult Create(Matricula Matriculas)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Matriculas.Add(Matriculas);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Matriculas);
            }
            catch
            {
                return View(Matriculas);
            }
        }

        // GET: Matricula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matricula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matricula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matricula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
