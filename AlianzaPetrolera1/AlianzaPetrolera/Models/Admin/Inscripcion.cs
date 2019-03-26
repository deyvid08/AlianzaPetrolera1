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
        [Display(Name = "Nombre")]
        public string Insc_NomEst { get; set; }
        [Display(Name = "Apellido")]
        public string Insc_ApeEst { get; set; }
        [Display(Name = "Documento")]
        public string Insc_DocEst { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Inscripción")]
        public DateTime Insc_FechInsc { get; set; }
        
        public List<Matricula> Matriculas { get; set; }
    }
}