using AlianzaPetrolera.Controllers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Models.Admin
{
    public class ReciboCaja
    {
        [Key]
        [Display(Name = "Id")]
        public int Reci_Id { get; set; }

        [Display(Name = "Matricula")]
        public int Costo_Matri { get; set; }

        [Display(Name = "Poliza de Accidente")]
        public int Costo_Poli { get; set; }

        [Display(Name = "Uniforme")]
        public int Costo_Unif { get; set; }

        [Display(Name = "Mensualidad")]
        public int Costo_Mensu { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha Matricula")]
        public DateTime Matr_Fecha { get; set; }

        [Display(Name = "Estado")]
        public EstadoMatricula Matri_Esta { get; set; }

        [Display(Name = "Costo Total")]
        public Nullable<float> Matri_CosTota {get; set; }
    }
    public class Calculadora
    {
        private float a, b, c, d;

        public float A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public float B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }

        }
        public Calculadora()
        {

        }

        public float Matricula(float a, float b)
        {
            float totaldesc = 0;
            float totalpag = 0;

            totaldesc = ((a * b)/100);
            totalpag = (a - totaldesc);
            return totalpag;
        }

        public float Poliac(float a, float b)
        {
            float totaldesc = 0;
            float totalpag = 0;

            totaldesc = ((a * b) / 100);
            totalpag = (a - totaldesc);
            return totalpag;
        }
        public float Uniforme(float a, float b)
        {
            float  totaldesc = 0;
            float totalpag = 0;

            totaldesc = ((a * b) / 100);
            totalpag = (a - totaldesc);
            return totalpag;
        }
        public float Mensualidad(float a, float b)
        {
            float  totaldesc = 0;
            float totalpag = 0;

            totaldesc = ((a * b) / 100);
            totalpag = (a - totaldesc);
            return totalpag;
        }
    }
}