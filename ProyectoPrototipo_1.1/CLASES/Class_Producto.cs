using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Producto
    {
        [Key]
        public int codigo { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public string lote { get; set; }
        public decimal PVP { get; set; }
        public decimal precio_unitario { get; set; }
        public DateTime fecha_cad { get; set; }
        public decimal descuento { get; set; }
        public decimal iva { get; set; }
    }

}
