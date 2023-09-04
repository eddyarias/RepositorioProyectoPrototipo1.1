using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._1.CLASES;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class FarmaciaDbContext : DbContext
    {
        public DbSet<Class_Proveedor> Proveedor { get; set; }
        public DbSet<Class_Producto> Producto { get; set; }
        public DbSet<Class_Cliente> Cliente { get; set; }

        public DbSet<Class_Usuario> Usuario { get; set; }
        public DbSet<Class_Parametro> Parametro { get; set; }

        //public DbSet<Class_Cliente> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connect.connect);
        }
    }

}

