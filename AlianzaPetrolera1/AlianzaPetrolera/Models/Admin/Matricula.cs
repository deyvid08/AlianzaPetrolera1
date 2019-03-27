using AlianzaPetrolera.Controllers.Enum;
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

        [Display(Name = "Inscripción")]
        //public int Insc_Id { get; set; }
        public Inscripcion Insc_Id { get; set; }

        [Display(Name = "Periodo")]
        public Periodo Peri_Id { get; set; }

        [Display(Name = "Categoria")]
        public string Cate_Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Matricula")]
        public DateTime Matr_Fecha { get; set; }

        [Display(Name = "Estado")]
        public EstadoMatricula Matri_Esta { get; set; }

        
    }
}