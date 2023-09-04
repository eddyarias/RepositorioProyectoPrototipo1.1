using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._1.CLASES
{
    public class Class_Parametro
    {
        [Key]
        public int id { get; set; }

        public string parametro { get; set; }

        public decimal valor { get; set; }
    }
}
