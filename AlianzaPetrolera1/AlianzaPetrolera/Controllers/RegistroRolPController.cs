using AlianzaPetrolera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers
{
    public class RegistroRolPController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: RegistroRolPersona
        public ActionResult Index()
        {
            return View(db.Roles.ToList());
        }

        // GET: RegistroRolPersona/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistroRolPersona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroRolPersona/Create
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

        // GET: RegistroRolPersona/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistroRolPersona/Edit/5
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

        // GET: RegistroRolPersona/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistroRolPersona/Delete/5
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
