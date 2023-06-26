using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Cliente
    {
        [Key]
        public int codigo_c { get; set; }

        public long ruc_c { get; set; }

        public string tipo_persona { get; set; }

        public string nombres_c { get; set; }

        public string apellidos_c { get; set; }

        public string parroquia { get; set; }

        public string direccion_c { get; set; }

        public string email_c { get; set; }

        public string telefono_c { get; set; }

        public DateTime fecha_nac { get; set; }

        public string observaciones_c { get; set; }
    }

}
