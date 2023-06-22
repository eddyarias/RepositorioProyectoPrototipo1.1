using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;


namespace ProyectoPrototipo_1._0.CLASES
{


    public class FarmaciaDbContext : DbContext
    {
        public FarmaciaDbContext()
            : base(GetConnectionString())
        {
            // Asegurar que la base de datos esté disponible
            Database.Connection.Open();
        }

        public DbSet<Class_Proveedores> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones adicionales para tu modelo de datos
            // Aquí puedes establecer relaciones, configurar propiedades, etc.
            base.OnModelCreating(modelBuilder);
        }

        private static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP-S7D8N62P\\MSSQLSERVER10";
            builder.InitialCatalog = "db_farmacy";
            builder.UserID = "jonathan";
            builder.Password = "PJseverous75";
            return builder.ToString();
        }
    }

}

