using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Proveedor
    {
        [Key]
        public int ruc { get; set; }

        public string razon_social { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string ciudad { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public string rubro { get; set; }

        public string observaciones { get; set; }

        public string informacion_bancaria { get; set; }

        public string calificacion { get; set; }
    }

}
