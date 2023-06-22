using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Proveedores : Form
    {
        //private FarmaciaDbContext dbContext;
        public Form_Proveedores()
        {
            //dbContext = new FarmaciaDbContext();
            InitializeComponent();

        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2-400,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;


            /*if (dbContext.Database.Exists())
            {
                dbContext.Proveedores.Load();
                dataGridView1.DataSource = dbContext.Proveedores.Local.ToBindingList();
                dbContext.SaveChanges();
                MessageBox.Show("Conexión exitosa.");
            }
            else
            {
                MessageBox.Show("Conexión no exitosa.");
            }*/

            // Crear 5 proveedores
            List<Class_Proveedores> proveedores = new List<Class_Proveedores>();

            for (int i = 1; i <= 5; i++)
            {
                Class_Proveedores proveedor = new Class_Proveedores();
                proveedor.ruc = i;
                proveedor.razon_social = "Proveedor " + i;
                proveedor.nombre = "Nombre " + i;
                proveedor.apellido = "Apellido " + i;
                proveedor.email = "proveedor" + i + "@example.com";
                proveedor.ciudad = "Ciudad " + i;
                proveedor.direccion = "Dirección " + i;
                proveedor.telefono = "12345678" + i;
                proveedor.rubro = "Rubro " + i;
                proveedor.observaciones = "Observaciones del proveedor " + i;
                proveedor.informacion_bancaria = "Información bancaria del proveedor " + i;
                proveedor.calificacion = "Calificación " + i;

                // Agregar el proveedor al contexto de la base de datos
                //dbContext.Proveedores.Add(proveedor);

                proveedores.Add(proveedor);
            }

            // Cargar los datos de los proveedores en el DataGridView
            dataGridView1.DataSource = proveedores;

            // Opcional: Guardar los cambios en la base de datos
            //dbContext.SaveChanges();

        }
        // Variable para almacenar el índice de la pestaña actual
        private int indicePestanaActual = 0;
        private void AvanzarPestana()
        {
            // Deshabilitar la pestaña actual
            //TCProveedores.TabPages[indicePestanaActual].Enabled = false;

            // Incrementar el índice de la pestaña actual
            indicePestanaActual++;

            // Habilitar la siguiente pestaña
            if (indicePestanaActual < TCProveedores.TabCount)
            {
                TCProveedores.TabPages[indicePestanaActual].Enabled = true;
                TCProveedores.SelectedIndex = indicePestanaActual;
            }
        }


        private void BInfoProveedor_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void BEvaluacion_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
                // Verifica que el evento ocurrió en una fila (y no en los encabezados o en una celda vacía)
                if (e.RowIndex >= 0)
                {
                    // Obtén los datos de la fila seleccionada
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["ruc"].Value.ToString();
                    textBox2.Text = row.Cells["razon_social"].Value.ToString();
                    textBox3.Text = row.Cells["nombre"].Value.ToString();
                    textBox4.Text = row.Cells["apellido"].Value.ToString();
                    textBox5.Text = row.Cells["email"].Value.ToString();
                    textBox6.Text = row.Cells["ciudad"].Value.ToString();
                    textBox7.Text = row.Cells["direccion"].Value.ToString();
                    textBox8.Text = row.Cells["telefono"].Value.ToString();
                    textBox12.Text = row.Cells["rubro"].Value.ToString();
                    textBox9.Text = row.Cells["observaciones"].Value.ToString();
                    //textBox15.Text = row.Cells["informacion_bancaria"].Value.ToString();
                    //txtCalificacion.Text = row.Cells["calificacion"].Value.ToString();
                    // Puedes agregar los demás atributos de los proveedores aquí
                    // utilizando los nombres de las columnas correspondientes en el DataGridView
                }

        }
    }
}
