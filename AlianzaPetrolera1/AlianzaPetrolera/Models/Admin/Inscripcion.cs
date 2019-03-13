using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class Inscripcion
    {
        [Key]
        [Display(Name = "Id")]
        public int Insc_ID { get; set; }
        [Display(Name = "Codigo Persona")]
        public string Pers_Doc { get; set; }
        [Display(Name = "Nombre Estudiante")]
        public string Insc_NomEst { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Inscripción")]
        public DateTime Insc_FechInsc { get; set; }
    }
}