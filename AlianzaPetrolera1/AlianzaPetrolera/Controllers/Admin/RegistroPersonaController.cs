using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.AlianzaBD;
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
            return View(db.Personas.ToList());
        }

        // GET: RegistroPersona/Details/5
        public ActionResult Details(string id)
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
                //Persona tbl = new Persona();

                //    // TODO: Add insert logic here
                //    tbl.Pers_Cod = Personas.Pers_Cod;        
                //    tbl.Pers_NickNom    = Personas.Pers_NickNom;
                //    tbl.Pers_Pwd        = Personas.Pers_Pwd;
                //    tbl.Pers_Nom        = Personas.Pers_Nom;
                //    tbl.Pers_Lstn1      = Personas.Pers_Lstn1;
                //    tbl.Pers_Lstn2      = Personas.Pers_Lstn2;
                //    tbl.Pers_TypeDoc    = Personas.Pers_TypeDoc;
                //    tbl.Pers_Doc        = Personas.Pers_Doc;
                //    tbl.Pers_Birth      = Personas.Pers_Birth;
                //    tbl.Pers_Dir        = Personas.Pers_Dir;
                //    tbl.Pers_Tel1       = Personas.Pers_Tel1;
                //    tbl.Pers_Tel2       = Personas.Pers_Tel2;
                //    tbl.Pers_Mail1      = Personas.Pers_Mail1;
                //    tbl.Pers_Mail2      = Personas.Pers_Mail2;
                //    tbl.Pers_Ingreso    = Personas.Pers_Ingreso;
                //    tbl.Pers_TotalPoints= Personas.Pers_TotalPoints;
                //    tbl.Ubic_Id = Personas.Ubic_Id;      
                //    tbl.Rolp_Id         = Personas.Rolp_Id;
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
        public ActionResult Edit(string id)
        {
            var item = db.Personas.Where(x => x.Pers_Cod == id).First();
            return View(item);
        }

        // POST: RegistroPersona/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection, Persona model)
        {
            try
            {
                // Se realiza la edicion de los datos dentro de la tabla persona
                var item = db.Personas.Where(x => x.Pers_Cod == model.Pers_Cod).First();
                item.Pers_Cod =     model.Pers_Cod;
                item.Pers_NickNom = model.Pers_NickNom;
                item.Pers_Pwd =     model.Pers_Pwd;
                item.Pers_Nom =     model.Pers_Nom;
                item.Pers_Lstn1 =   model.Pers_Lstn1;
                item.Pers_Lstn2 =   model.Pers_Lstn2;
                item.Pers_TypeDoc = model.Pers_TypeDoc;
                item.Pers_Doc =     model.Pers_Doc;
                item.Pers_Birth =   model.Pers_Birth;
                item.Pers_Dir =     model.Pers_Dir;
                item.Pers_Tel1 =    model.Pers_Tel1;
                item.Pers_Tel2 =    model.Pers_Tel2;
                item.Pers_Mail1 =   model.Pers_Mail1;
                item.Pers_Mail2 =   model.Pers_Mail2;
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
