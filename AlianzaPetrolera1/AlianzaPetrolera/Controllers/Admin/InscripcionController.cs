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
        public ActionResult Edit(string id)
        {
            var item = db.Personas.Where(x => x.Pers_Cod == id).First();
            return View(item);
        }

        // POST: RegistroPersona/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection, Inscripcion model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Inscripciones.Where(x => x.Pers_Cod == model.Pers_Cod).First();
                item.Pers_Cod = model.Pers_Cod;
                
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
                Persona X = db.Personas.Find(id);
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
        public ActionResult Delete(string id, FormCollection collection, Persona X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Personas.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Personas.Remove(X);
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
