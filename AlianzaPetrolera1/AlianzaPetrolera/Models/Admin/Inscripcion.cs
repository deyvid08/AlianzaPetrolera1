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
        
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}