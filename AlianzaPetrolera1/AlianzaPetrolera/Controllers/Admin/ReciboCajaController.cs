using AlianzaPetrolera.Models;
using AlianzaPetrolera.Models.Admin;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class ReciboCajaController : Controller
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
            var q = new ActionAsPdf("Create");
            return q;
        }

        // GET: Recibo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recibo/Create
        public ActionResult Create(string nombrecate,string nombreestu)
        {
            ViewBag.Message = nombrecate;
            ViewBag.Message2 = nombreestu;
            return View();
        }

        // POST: Recibo/Create
        [HttpPost]
        public ActionResult Create(int value1, int value2, int value3, int value4, int value5, int value6, int value7, int value8, String calc,string nombrecate,string nombreestu)
        {


            ViewBag.Message = nombrecate;
            ViewBag.Message2 = nombreestu;


            try
            {
                    ReciboCaja r = new ReciboCaja();

                    Calculadora c = new Calculadora();
                    decimal totalma = 0;
                    decimal totalp = 0;
                    decimal totalu = 0;
                    decimal totalme = 0;
                    decimal totalpago = 0;
                    

                    totalma = c.Matricula(value1, value2);
                    totalp = c.Poliac(value3, value4);
                    totalu = c.Uniforme(value5, value6);
                    totalme = c.Mensualidad(value7, value8);
                    totalpago = (totalma + totalp + totalu + totalme);
                    ViewBag.totfin = "Total a pagar" + totalpago;
                                   
                    r.Matri_CosTota = totalpago;
                    //return Content("Resultado:" + totalpago);
                return View();

                //return RedirectToAction("Index");
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
