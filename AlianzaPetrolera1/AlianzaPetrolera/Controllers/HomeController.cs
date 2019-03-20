﻿using AlianzaPetrolera.Models;
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

                    //Crear Role 

                    var resultado = roleManager.Create(new IdentityRole("Padre"));

                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

                    //Agregar Usuario A Role

                    resultado = userManager.AddToRole(userId, "Padre");

                    //Usuario Esta En Rol?
                    var usuarioEstaEnRol = userManager.IsInRole(userId, "Padre");

                }
            }
            return View();
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