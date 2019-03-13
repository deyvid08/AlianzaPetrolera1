using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class InscripcionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Inscripcion
        public ActionResult Index()
        {

            //var datospersona = db.Inscripciones.Join(db.Users, ins => ins.Pers_Doc, use => use.Id, (ins, use) => new { ins, use }).ToString();

            return View(db.Inscripciones.ToList());
        }

        // GET: Inscripcion/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Inscripcion X = db.Inscripciones.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }
            }
        }


        // GET: RegistroPersona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroPersona/Create
        [HttpPost]
        public ActionResult Create(Inscripcion Inscripciones)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Inscripciones.Add(Inscripciones);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Inscripciones);
            }
            catch
            {
                return View(Inscripciones);
            }
        }

        // GET: RegistroPersona/Edit/5
        public ActionResult Edit(int id)
        {
            var item = db.Inscripciones.Where(x => x.Insc_ID == id).First();
            return View(item);
        }

        // POST: RegistroPersona/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Inscripcion model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Inscripciones.Where(x => x.Insc_ID == model.Insc_ID).First();
                item.Insc_ID = model.Insc_ID;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroPersona/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Inscripcion X = db.Inscripciones.Find(id);
                if (X == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    return View(X);
                }
            }

        }

        // POST: RegistroPersona/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, Inscripcion X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Inscripciones.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Inscripciones.Remove(X);
                        db.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
                return View(X);
            }
            catch
            {
                return View(X);
            }
        }
    }
}
