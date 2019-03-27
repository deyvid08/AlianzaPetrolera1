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
    
    public class MatriculaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Matricula
        public ActionResult Index()
        {
            return View(db.Matriculas.ToList());
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Matricula X = db.Matriculas.Find(id);
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

        // GET: Matricula/Create
        public ActionResult Create(string Nomcategoria, string cod_persona, string nom_estu, string apell_estu, int documento_estu, int idinscripcion)
        {
            ViewBag.NombreEstu = nom_estu;
            ViewBag.CodPers = cod_persona;
            ViewBag.IdInscripcion = idinscripcion;
            ViewBag.documentoestud = documento_estu;
            ViewBag.apellidoes = apell_estu;
            ViewBag.Nomcategoria = Nomcategoria;

            return View();
        }

        // POST: Matricula/Create
        [HttpPost]
        public ActionResult Create(Matricula Matriculas )
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
            var item = db.Matriculas.Where(x => x.Matri_Id == id).First();
            return View(item);
        }

        // POST: Matricula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Matricula model)
        {
            try
            {
                // TODO: Add update logic here
                var item = db.Matriculas.Where(x => x.Matri_Id == model.Matri_Id).First();
                //item.Insc_Id = model.Insc_Id;
                //item.Peri_Id = model.Peri_Id;
                //item.Cate_Id = model.Cate_Id;
                //item.Matr_Fecha = model.Matr_Fecha;
                item.Matri_Esta = model.Matri_Esta;
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matricula/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                Matricula X = db.Matriculas.Find(id);
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

        // POST: Matricula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection, Matricula X)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    X = db.Matriculas.Find(id);

                    if (X == null)
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        db.Matriculas.Remove(X);
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
