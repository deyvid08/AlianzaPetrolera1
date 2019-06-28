using AlianzaPetrolera.Controllers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Models.AlianzaBD
{
    public class Persona
    {
        public List<ApplicationUser> Users { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<SelectListItem> Ubicaciones { get; set; }
        [Key] [Display(Name = "Codigo")]
        public string Pers_Cod { get; set; }
        [Display(Name = "Usuario")]
        public string Pers_NickNom { get; set; }
        [Display(Name = "Contraseña")]
        public string Pers_Pwd { get; set; }
        [Display(Name = "Nombre")]
        public string Pers_Nom { get; set; }
        [Display(Name = "Primer Apellido")]
        public string Pers_Lstn1 { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Pers_Lstn2 { get; set; }
        [Display(Name = "Tipo de Documento")]
        public TipoDoc Pers_TypeDoc { get; set; }
        [Display(Name = "Documento")]
        public string Pers_Doc { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Pers_Birth { get; set; }
        [Display(Name = "Dirección")]
        public string Pers_Dir { get; set; }
        [Display(Name = "Celular")] 
        public string Pers_Tel1 { get; set; }
        [Display(Name = "Telefono")]
        public string Pers_Tel2 { get; set; }
        [Display(Name = "Correo1")]
        public string Pers_Mail1 { get; set; }
        [Display(Name = "Correo2")]
        public string Pers_Mail2 { get; set; }
        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Pers_Ingreso { get; set; }
        [Display(Name = "Total de Puntos")]
        public int Pers_TotalPoints { get; set; }
        [Display(Name = "Ciudad")]
        public Ubic Ubic_Id { get; set; }
        [Display(Name = "ROL")]
        public RolHijo Rolp_Id { get; set; }
        [Display(Name ="Padre")]
        public string Padre_Id { get; set; }
    }
}