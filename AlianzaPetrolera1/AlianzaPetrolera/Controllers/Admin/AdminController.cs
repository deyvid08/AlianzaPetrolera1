using AlianzaPetrolera.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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

        public ActionResult BienvenidaPadre(string roles)
        {

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                var userId = User.Identity.GetUserId();

                switch (roles)
                {
                    
                    case "Padre":

                        ////rear Role 
                        var resultado = roleManager.Create(new IdentityRole("Padre"));
                        ////Agregar Usuario A Role

                        resultado = userManager.AddToRole(userId, "Padre");
                        break;

                    case "Admin":

                        var resultado1 = roleManager.Create(new IdentityRole("Administrador"));
                        resultado = userManager.AddToRole(userId, "Administrador");

                        break;

                    case "AdminJefe":

                        var resultado2 = roleManager.Create(new IdentityRole("AdminJefe"));
                        resultado = userManager.AddToRole(userId, "AdminJefe");

                        break;

                    case "Entrenador":

                        var resultado3 = roleManager.Create(new IdentityRole("Entrenador"));
                        resultado = userManager.AddToRole(userId, "Entrenador");
                        break;

                    

                }


            }

            return View();
        }

    }
}