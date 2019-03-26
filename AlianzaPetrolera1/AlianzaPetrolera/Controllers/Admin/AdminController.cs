using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers.Admin
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //Vista principal Administrador
        public ActionResult AdminIndex()
        {
            return View();
        }
        public ActionResult AdminJefe()
        {
            return View();
        }
        public ActionResult Entrenador()
        {
            return View();
        }
        public ActionResult SuperAdmin()
        {
            return View();
        }
    }
}