using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.AlianzaBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class RegistroUbicacionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: RegistroUbicacion
        public ActionResult Index()
        {
            return View(db.Ubicaciones.ToList());
        }

        // GET: RegistroUbicacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Ubicacion X = db.Ubicaciones.Find(id);
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


        // GET: RegistroUbicacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroUbicacion/Create
        [HttpPost]
        public ActionResult Create(Ubicacion Ubicaciones)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Ubicaciones.Add(Ubicaciones);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Ubicaciones);
            }
            catch
            {
                return View(Ubicaciones);
            }
        }

        // GET: RegistroUbicacion/Edit/5
        public ActionResult Edit(int id)
        {
            var item = db.Ubicaciones.Where(x => x.Ubic_Id == id).First();
            return View(item);
        }

        // POST: RegistroUbicacion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Ubicacion model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Ubicaciones.Where(x => x.Ubic_Id == model.Ubic_Id).First();
                item.Ubic_Id = model.Ubic_Id;
                item.Ubic_Name = model.Ubic_Name;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegistroUbicacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Ubicacion X = db.Ubicaciones.Find(id);
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

        // POST: RegistroUbicacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, Ubicacion X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Ubicaciones.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Ubicaciones.Remove(X);
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
