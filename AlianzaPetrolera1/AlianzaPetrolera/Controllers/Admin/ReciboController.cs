using AlianzaPetrolera.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class ReciboController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: RegistroPersona
        public ActionResult Index()
        {
            var TodoRecibo = db.RecibosCajas.ToList();
            return View(TodoRecibo);
        }

        public ActionResult ImprimirTodas()
        {
            var q = new ActionAsPdf("Index");
            return q;
        }

        // GET: Recibo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recibo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recibo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recibo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recibo/Edit/5
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

        // GET: Recibo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recibo/Delete/5
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
