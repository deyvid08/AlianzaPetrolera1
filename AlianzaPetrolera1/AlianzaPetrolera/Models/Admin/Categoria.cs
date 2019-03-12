using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class Categoria
    {
        [Key]
        [Display(Name = "Id")]
        public int Cate_Id { get; set; }

        [Display(Name = "Categoria")]
        public string Cate_Name { get; set; }

    }
}