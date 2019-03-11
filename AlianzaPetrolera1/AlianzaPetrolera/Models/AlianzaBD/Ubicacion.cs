using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.AlianzaBD
{
    public class Ubicacion
    {
        [Key]
        [Display(Name = "Id")]
        public int Ubic_Id { get; set; }
        [Display(Name = "Ubicación")]
        public string Ubic_Name { get; set; }
    }
}