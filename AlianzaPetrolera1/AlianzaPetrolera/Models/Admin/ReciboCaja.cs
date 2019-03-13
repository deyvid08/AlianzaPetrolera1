using AlianzaPetrolera.Controllers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class ReciboCaja
    {
        [Key]
        [Display(Name = "Id")]
        public int Reci_Id { get; set; }

        [Display(Name = "Matricula")]
        public int Costo_Matri { get; set; }

        [Display(Name = "Poliza de Accidente")]
        public int Costo_Poli { get; set; }

        [Display(Name = "Uniforme")]
        public int Costo_Unif { get; set; }

        [Display(Name = "Mensualidad")]
        public int Costo_Mensu { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Matricula")]
        public DateTime Matr_Fecha { get; set; }

        [Display(Name = "Estado")]
        public EstadoMatricula Matri_Esta { get; set; }


    }
}