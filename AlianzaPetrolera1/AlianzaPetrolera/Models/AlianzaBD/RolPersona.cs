using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.AlianzaBD
{
    public class RolPersona
    {        
        [Key][Display(Name = "Id Rol")]
        public int Rolp_Id { get; set; }
        [Display(Name = "Rol")]
        public string Rolp_Rol { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}