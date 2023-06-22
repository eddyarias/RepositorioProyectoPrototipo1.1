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
        private FarmaciaDbContext dbContext;
        public Form_Inventario()
        {
            dbContext = new FarmaciaDbContext();
            InitializeComponent();
        }

        private void Form_Inventario_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            dbContext.Producto.Load();
            dataGridView1.DataSource = dbContext.Producto.Local.ToBindingList();
            ///dbContext.SaveChanges();

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