using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.AlianzaBD;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers
{
    public class RegistroPersonaController : Controller

    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: RegistroPersona
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();

            var hijos = db.Personas.Where(x => x.Padre_Id == userId).ToList();

            return View(hijos);
        }

        // GET: RegistroPersona/Details/5
        public ActionResult Details(int? id)
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
        //Vista principal usuario padre
        public ActionResult PadreIndex()
        {
            return View();
        }

        // GET: RegistroPersona/Create
        public ActionResult Create()
        {
            return View();
        }
         // POST: RegistroPersona/Create
        [HttpPost]
        public ActionResult Create(Persona Personas)
        {
            try
            {
                if (ModelState.IsValid) {
                                      
                    db.Personas.Add(Personas);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Personas);
            }
            catch
            {
                return View(Personas);
            }
        }

        // GET: RegistroPersona/Edit/5
        public ActionResult Edit(int id)
        {
            var item = db.Personas.Where(x => x.Pers_Id == id).First();
            return View(item);
        }

        // POST: RegistroPersona/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection, Persona model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Personas.Where(x => x.Pers_Id == model.Pers_Id).First();
                item.Pers_Id =     model.Pers_Id;
                item.Pers_Nom =     model.Pers_Nom;
                item.Pers_Apel =   model.Pers_Apel;
                item.Pers_TypeDoc = model.Pers_TypeDoc;
                item.Pers_Doc =     model.Pers_Doc;
                item.Pers_Birth =   model.Pers_Birth;
                item.Pers_Dir =     model.Pers_Dir;
                item.Pers_Tel1 =    model.Pers_Tel1;
                item.Pers_Tel2 =    model.Pers_Tel2;
                item.Pers_Mail1 =   model.Pers_Mail1;
                item.Pers_Ingreso = model.Pers_Ingreso;
                item.Pers_TotalPoints = model.Pers_TotalPoints;
                item.Ubic_Id =          model.Ubic_Id;
                item.Rolp_Id = model.Rolp_Id;
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
