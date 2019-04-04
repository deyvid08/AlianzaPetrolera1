using AlianzaPetrolera.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var userId = User.Identity.GetUserId();

                    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));


                    
                    ////Crear Role 

                    //var resultado = roleManager.Create(new IdentityRole("Padre"));
                    //var resultado2 = roleManager.Create(new IdentityRole("AdminJefe"));
                    //var resultado3 = roleManager.Create(new IdentityRole("Entrenador"));

                    //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

                    ////Agregar Usuario A Role
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                    //resultado = userManager.AddToRole(userId, "Padre");
               
                    ////Usuario Esta En Rol?
                    //var usuarioEstaEnRol = userManager.IsInRole(userId, "Administrador");

                    var usuariorol = userManager.IsInRole(userId, "Administrador");
                    var usuariorol2 = userManager.IsInRole(userId, "Padre");
                    var usuariorol3 = userManager.IsInRole(userId, "SuperAdmin");
                    var usuariorol4 = userManager.IsInRole(userId, "AdminJefe");
                    var usuariorol5 = userManager.IsInRole(userId, "Entrenador");

                    if (usuariorol == true)
                    {
                        return RedirectToAction("AdminIndex", "Admin");
                    }
                    else if (usuariorol2 == true)
                    {
                        return RedirectToAction("PadreIndex", "RegistroPersona");
                    }

                    else if (usuariorol3 == true)
                    {
                        return RedirectToAction("SuperAdmin", "Admin");
                    }

                    else if (usuariorol4 == true)
                    {
                        return RedirectToAction("AdminJefe", "Admin");
                    }

                    else if (usuariorol5 == true)
                    {
                        return RedirectToAction("Entrenador", "Admin");
                    }




                }
            }




            return View("");
        }
        [Authorize(Users = "Dmartinez")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "Padre")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}