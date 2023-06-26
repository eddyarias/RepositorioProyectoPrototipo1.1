using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class FarmaciaDbContext : DbContext
    {
        public DbSet<Class_Proveedor> Proveedor { get; set; }
        public DbSet<Class_Producto> Producto { get; set; }
        public DbSet<Class_Cliente> Cliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //CAMBIAR LA CADENA DE CONEXIÓN CON SUS DATOS
            optionsBuilder.UseSqlServer("Server=LAPTOP-S7D8N62P\\MSSQLSERVER10;Database=db_farmacia;User=jonathan;Password=PJseverous75;TrustServerCertificate=true;");

        }
    }

}

