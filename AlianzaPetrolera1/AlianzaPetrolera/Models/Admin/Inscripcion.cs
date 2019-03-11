using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}