using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class Matricula
    {
        [Key]
        [Display(Name = "Id")]
        public int Matri_Id { get; set; }

        [ForeignKey("Company")]
        public string Insc_Id { get; set; }
        public virtual Inscripcion Inscripcion { get; set; }

        [Display(Name = "Nombre Estudiante")]
        public string Insc_NomEst { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Matricula")]
        public DateTime Matr_Fecha { get; set; }
    }
}