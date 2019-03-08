﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using AlianzaPetrolera.Controllers.Enum;
using AlianzaPetrolera.Models.AlianzaBD;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AlianzaPetrolera.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [Display(Name = "Codigo")]
        public string Pers_Cod { get; set; }
        [Display(Name = "Usuario")]
        public string Pers_NickNom { get; set; }
        [Display(Name = "Nombres")]
        public string Pers_Nom { get; set; }
        [Display(Name = "Apellidos")]
        public string Pers_Lstn1 { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Pers_Lstn2 { get; set; }
        [Display(Name = "Tipo de Documento")]
        public TipoDoc Pers_TypeDoc { get; set; }
        [Display(Name = "Documento")]
        public string Pers_Doc { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Pers_Birth { get; set; }
        [Display(Name = "Dirección")]
        public string Pers_Dir { get; set; }
        [Display(Name = "Celular")]
        public string Pers_Tel1 { get; set; }
        [Display(Name = "Telefono")]
        public string Pers_Tel2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Pers_Ingreso { get; set; }
        [Display(Name = "Total de Puntos")]
        public int Pers_TotalPoints { get; set; }
        [Display(Name = "Ubicación")]
        public int Ubic_Id { get; set; }
        [Display(Name = "ROL")]
        public Roles Rolp_Id { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<Persona> Personas { set; get; }
        //public DbSet<RolPersona> Roles { set; get; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<AlianzaPetrolera.Models.RegisterViewModel> RegisterViewModels { get; set; }
    }
}