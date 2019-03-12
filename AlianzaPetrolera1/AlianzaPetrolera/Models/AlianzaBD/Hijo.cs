using AlianzaPetrolera.Controllers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlianzaPetrolera.Models.AlianzaBD
{
    public class Hijo
    {
        public List<ApplicationUser> Users { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
        public IEnumerable<SelectListItem> Ubicaciones { get; set; }
        [Key]
        [Display(Name = "Codigo")]
        public string Hijo_Cod { get; set; }
        [Display(Name = "Usuario")]
        public string Hijo_NickNom { get; set; }
        [Display(Name = "Contraseña")]
        public string Hijo_Pwd { get; set; }
        [Display(Name = "Nombre")]
        public string Hijo_Nom { get; set; }
        [Display(Name = "Primer Apellido")]
        public string Hijo_Lstn1 { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Hijo_Lstn2 { get; set; }
        [Display(Name = "Tipo de Documento")]
        public TipoDoc Hijo_TypeDoc { get; set; }
        [Display(Name = "Documento")]
        public string Hijo_Doc { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Hijo_Birth { get; set; }
        [Display(Name = "Dirección")]
        public string Hijo_Dir { get; set; }
        [Display(Name = "Celular")]
        public string Hijo_Tel1 { get; set; }
        [Display(Name = "Telefono")]
        public string Hijo_Tel2 { get; set; }
        [Display(Name = "Correo 1")]
        public string Hijo_Mail1 { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Display(Name = "Fecha de Ingreso")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Hijo_Ingreso { get; set; }
        [Display(Name = "Total de Puntos")]
        public int Hijo_TotalPoints { get; set; }
        [Display(Name = "Ubicación")]
        public Nullable<int> Ubic_Id { get; set; }
        [Display(Name = "ROL")]
        public RolHijo Rolp_Id { get; set; }
    }
}