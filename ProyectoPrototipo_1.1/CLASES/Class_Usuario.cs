using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrototipo_1._1.CLASES
{
    public class Class_Usuario
    {
        [Key]
        [MaxLength(10)]
        public string cedula_identidad { get; set; }

        [Required]
        [MaxLength(20)]
        public string username { get; set; }

        [MaxLength(128)] // Para almacenar el hash SHA-512
        public string pass { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression("^(Vendedor|Administrador)$")]
        public string tipo_usuario { get; set; }
    }

}
