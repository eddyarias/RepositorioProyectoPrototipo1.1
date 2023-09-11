using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Cliente
    {
        [Key]
        public long cedula { get; set; }
        public string? nombres_c { get; set; }
        public string? apellidos_c { get; set; }
        public string? direccion_c { get; set; }
        public string? email_c { get; set; }
        public string? telefono_c { get; set; }
        public DateTime? fecha_nac { get; set; }
        public decimal descuentos { get; set; }
    }

}
