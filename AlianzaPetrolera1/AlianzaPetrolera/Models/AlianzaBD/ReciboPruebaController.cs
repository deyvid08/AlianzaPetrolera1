using AlianzaPetrolera.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Models.AlianzaBD
{
    public class ReciboPruebaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ReciboPrueba
        public ActionResult Index()
        {
            return View(db.RecibosCajas.ToList());
        }

        // GET: ReciboPrueba/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                ReciboCaja X = db.RecibosCajas.Find(id);
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

        // GET: ReciboPrueba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReciboPrueba/Create
        [HttpPost]
        public ActionResult Create(ReciboCaja ReciboCajas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.RecibosCajas.Add(ReciboCajas);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(ReciboCajas);
            }
            catch
            {
                return View(ReciboCajas);
            }
        }

        // GET: ReciboPrueba/Edit/5
        public ActionResult Edit(int id, ReciboCaja model)
        {
            var item = db.RecibosCajas.Where(x => x.Reci_Id == id).First();
            return View(item);
        }

        // POST: ReciboPrueba/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, ReciboCaja model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.RecibosCajas.Where(x => x.Reci_Id == model.Reci_Id).First();
                item.Reci_Id = model.Reci_Id;
                item.Reci_Id = model.Reci_Id;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReciboPrueba/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                ReciboCaja X = db.RecibosCajas.Find(id);
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

        // POST: ReciboPrueba/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, ReciboCaja X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.RecibosCajas.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.RecibosCajas.Remove(X);
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
