using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Inventario : Form
    {
        Class_Inventario inventario;
        public Form_Inventario()
        {
            this.inventario = new Class_Inventario();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form_Inventario_Load(object sender, EventArgs e)
        {

            // READ: inventario en el dataGridView1
            dataGridView1.DataSource = inventario.productos;
        }

        private void ClearTextFields()
        {
            //textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox14.Clear();
            //tabPage4.Text = string.Empty;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value);

            //    // Buscar el producto en la lista de productos del inventario
            //    Class_Producto? productoToUpdate = inventario.productos.FirstOrDefault(p => p.codigo == codigo);

            //    if (productoToUpdate != null)
            //    {
            //        textBox11.Text = productoToUpdate.codigo.ToString();
            //        textBox10.Text = productoToUpdate.cantidad.ToString();
            //        textBox9.Text = productoToUpdate.descripcion;
            //        textBox8.Text = productoToUpdate.lote;
            //        textBox14.Text = productoToUpdate.PVP.ToString();
            //        textBox7.Text = productoToUpdate.precio_unitario.ToString();
            //        textBox4.Text = productoToUpdate.fecha_cad.ToString();
            //        textBox2.Text = productoToUpdate.descuento.ToString();
            //        textBox15.Text = productoToUpdate.iva.ToString();
            //    }
            //}
        }
        private void BAgregar_Click(object sender, EventArgs e)
        {
            //// Obtener los datos ingresados por el usuario
            //int codigo;
            //if (!int.TryParse(textBox11.Text, out codigo))
            //{
            //    MessageBox.Show("Ingrese un código válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //int cantidad;
            //if (!int.TryParse(textBox10.Text, out cantidad))
            //{
            //    MessageBox.Show("Ingrese una cantidad válida.");
            //    return; // Salir del método sin crear el producto
            //}

            //string descripcion = textBox9.Text.Trim();
            //if (string.IsNullOrEmpty(descripcion))
            //{
            //    MessageBox.Show("Ingrese una descripción válida.");
            //    return; // Salir del método sin crear el producto
            //}

            //string lote = textBox8.Text.Trim();
            //if (string.IsNullOrEmpty(lote))
            //{
            //    MessageBox.Show("Ingrese un lote válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //decimal pvp;
            //if (!decimal.TryParse(textBox14.Text, out pvp))
            //{
            //    MessageBox.Show("Ingrese un PVP válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //decimal precioUnitario;
            //if (!decimal.TryParse(textBox7.Text, out precioUnitario))
            //{
            //    MessageBox.Show("Ingrese un precio unitario válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //DateTime fechaCaducidad;
            //if (!DateTime.TryParse(textBox4.Text, out fechaCaducidad))
            //{
            //    MessageBox.Show("Ingrese una fecha de caducidad válida.");
            //    return; // Salir del método sin crear el producto
            //}

            //decimal descuento;
            //if (!decimal.TryParse(textBox2.Text, out descuento))
            //{
            //    MessageBox.Show("Ingrese un descuento válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //decimal iva;
            //if (!decimal.TryParse(textBox15.Text, out iva))
            //{
            //    MessageBox.Show("Ingrese un IVA válido.");
            //    return; // Salir del método sin crear el producto
            //}

            //// Verificar si el código de producto ya existe en la base de datos
            ///*bool codigoExists = dbContext.Producto.Any(p => p.codigo == codigo);*/

            //bool codigoExists = inventario.productos.Any(p => p.codigo == codigo);

            //if (codigoExists)
            //{
            //    MessageBox.Show("El código de producto ya existe. Ingrese un código único.");
            //    return; // Salir del método sin crear el producto
            //}


            //// Crear una nueva instancia de Producto y asignar los valores
            //Class_Producto newProducto = new Class_Producto
            //{
            //    codigo = codigo,
            //    cantidad = cantidad,
            //    descripcion = descripcion,
            //    lote = lote,
            //    PVP = pvp,
            //    precio_unitario = precioUnitario,
            //    fecha_cad = fechaCaducidad,
            //    descuento = descuento,
            //    iva = iva
            //};

            //// Agregar el nuevo producto al inventario
            //inventario.productos.Add(newProducto);
            //MessageBox.Show("Producto creado exitosamente");
            //// Actualizar el origen de datos del DataGridView con el inventario
            //dataGridView1.DataSource = inventario.productos.ToList();
            //ClearTextFields();
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            //// Obtener el código del producto a actualizar
            //int codigo = int.Parse(textBox11.Text);

            //// Crear una instancia de Class_Producto con los datos actualizados
            //Class_Producto productoActualizado = new Class_Producto
            //{
            //    cantidad = int.Parse(textBox10.Text),
            //    descripcion = textBox9.Text,
            //    lote = textBox8.Text,
            //    PVP = decimal.Parse(textBox14.Text),
            //    precio_unitario = decimal.Parse(textBox7.Text),
            //    fecha_cad = DateTime.Parse(textBox4.Text),
            //    descuento = decimal.Parse(textBox2.Text),
            //    iva = decimal.Parse(textBox15.Text)
            //};

            //// Llamar al método ActualizarProducto del inventario
            //inventario.ActualizarProducto(codigo, productoActualizado);
            //MessageBox.Show("Producto actualizado exitosamente");
            //// Actualizar el origen de datos del DataGridView con el inventario
            //dataGridView1.DataSource = inventario.productos.ToList();
            //ClearTextFields();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            //// Obtener el código del producto desde el TextBox
            //    int codigo = Convert.ToInt32(textBox11.Text);

            //    // Verificar si el código de producto existe en el inventario
            //    bool codigoExists = inventario.productos.Any(p => p.codigo == codigo);

            //    if (codigoExists)
            //    {
            //        // Mostrar el diálogo de confirmación
            //        DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo);
            //        if (result == DialogResult.Yes)
            //        {
            //            // Eliminar el producto del inventario
            //            inventario.EliminarProducto(codigo);
            //            MessageBox.Show("Producto eliminado exitosamente");

            //            // Actualizar el DataGridView con la lista de productos del inventario
            //            dataGridView1.DataSource = inventario.productos.ToList();
            //            ClearTextFields();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontró el producto");
            //        ClearTextFields();
            //    }
        }
    }
}