using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Inventario : Form
    {
        public Form_Inventario()
        {
            InitializeComponent();
        }

        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            //OBJETO TIPO INVENTARIO
            Class_Inventario inventario = new Class_Inventario();

            // Agregar productos al inventario
            /*Class_Producto producto1 = new Class_Producto
            {
                codigo = 1,
                cantidad = 10,
                descripcion = "Producto 1",
                lote = "Lote 123",
                PVP = 19.99m,
                precio_unitario = 15.99m,
                fecha_cad = DateTime.Parse("2023-12-31"),
                descuento = 0.1m,
                iva = 0.16m
            };
            inventario.AgregarProducto(producto1);*/

            // Mostrar el inventario en el dataGridView1
            dataGridView1.DataSource = inventario.productos;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el evento ocurrió en una fila (y no en los encabezados o en una celda vacía)
            /* if (e.RowIndex >= 0)
             {
                 // Obtén los datos de la fila seleccionada
                 DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                 txtCodigoP.Text = row.Cells["Código"].Value.ToString();
                 txtNombreP.Text = row.Cells["Column1"].Value.ToString();
                 txtDesP.Text = row.Cells["Column3"].Value.ToString();
                 txtPrecioP.Text = row.Cells["Column2"].Value.ToString();
                 txtCantidadP.Text = row.Cells["Cantidad"].Value.ToString();
                 txtFechaCad.Text = row.Cells["Feccad"].Value.ToString();
             }*/
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}