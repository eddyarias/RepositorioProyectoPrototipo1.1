using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0.CLASES
{
    public class Class_Inventario
    {
        private FarmaciaDbContext dbContext;
        public List<Class_Producto> productos;

        public Class_Inventario()
        {
            dbContext = new FarmaciaDbContext();
            productos = new List<Class_Producto>();
            productos = dbContext.Producto.ToList();
        }

        public void AgregarProducto(Class_Producto producto)
        {
            dbContext.SaveChanges();
            productos.Add(producto);
        }

        public List<Class_Producto> ObtenerProductos()
        {
            return productos;
        }

        public void ActualizarProducto(int codigo, Class_Producto productoActualizado)
        {
            Class_Producto? productoExistente = productos.FirstOrDefault(p => p.codigo == codigo);

            if (productoExistente != null)
            {
                productoExistente.cantidad = productoActualizado.cantidad;
                productoExistente.descripcion = productoActualizado.descripcion;
                productoExistente.lote = productoActualizado.lote;
                productoExistente.PVP = productoActualizado.PVP;
                productoExistente.precio_unitario = productoActualizado.precio_unitario;
                productoExistente.fecha_cad = productoActualizado.fecha_cad;
                productoExistente.descuento = productoActualizado.descuento;
                productoExistente.iva = productoActualizado.iva;
            }
        }

        public Class_Producto? BuscarProducto(int codigo)
        {
            return productos.FirstOrDefault(p => p.codigo == codigo);
        }

        public void EliminarProducto(int codigo)
        {
            Class_Producto? producto = productos.FirstOrDefault(p => p.codigo == codigo);

            if (producto != null)
            {
                productos.Remove(producto);
            }
        }

    }
}
