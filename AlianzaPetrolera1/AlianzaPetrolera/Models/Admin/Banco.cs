using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class Banco
    {
        [Key]
        [Display(Name = "Id")]
        public int Banc_Id { get; set; }

        [Display(Name = "NombreBanco")]
        public string Banc_Nom { get; set; }

        [Display(Name = "CuentaBanco")]
        public string Banc_Cuenta { get; set; }

        public ICollection<ReciboCaja> Reci_Id { get; set; }

    }
    
}