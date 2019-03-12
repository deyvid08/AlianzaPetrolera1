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
    public class RegistroHijoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Hijo
        public ActionResult Index()
        {
            return View(db.Hijos.ToList());
        }

        // GET: Hijo/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Hijo X = db.Hijos.Find(id);
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


        // GET: Hijo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hijo/Create
        [HttpPost]
        public ActionResult Create(Hijo Hijos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Hijos.Add(Hijos);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Hijos);
            }
            catch
            {
                return View(Hijos);
            }
        }

        // GET: Hijo/Edit/5
        public ActionResult Edit(string id)
        {
            var item = db.Hijos.Where(x => x.Hijo_Cod == id).First();
            return View(item);
        }

        // POST: Hijo/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection, Hijo model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Hijos.Where(x => x.Hijo_Cod == model.Hijo_Cod).First();
                item.Hijo_Cod = model.Hijo_Cod;
                item.Hijo_NickNom = model.Hijo_NickNom;
                item.Hijo_Pwd = model.Hijo_Pwd;
                item.Hijo_Nom = model.Hijo_Nom;
                item.Hijo_Lstn1 = model.Hijo_Lstn1;
                item.Hijo_Lstn2 = model.Hijo_Lstn2;
                item.Hijo_TypeDoc = model.Hijo_TypeDoc;
                item.Hijo_Doc = model.Hijo_Doc;
                item.Hijo_Birth = model.Hijo_Birth;
                item.Hijo_Dir = model.Hijo_Dir;
                item.Hijo_Tel1 = model.Hijo_Tel1;
                item.Hijo_Tel2 = model.Hijo_Tel2;
                item.Hijo_Mail1 = model.Hijo_Mail1;
                item.UserId = model.UserId;
                item.Hijo_Ingreso = model.Hijo_Ingreso;
                item.Hijo_TotalPoints = model.Hijo_TotalPoints;
                item.Ubic_Id = model.Ubic_Id;
                item.Rolp_Id = model.Rolp_Id;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hijo/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Hijo X = db.Hijos.Find(id);
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

        // POST: Hijo/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection, Hijo X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Hijos.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Hijos.Remove(X);
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