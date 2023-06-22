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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Agregar productos al DataGridView
            dataGridView1.Rows.Add("001", "Pasta dental", "Aseo Personal", 3.99, 10, "10/02/2024");
            dataGridView1.Rows.Add("002", "Jabón de manos", "Aseo Personal", 2.49, 20, "15/03/2024");
            dataGridView1.Rows.Add("003", "Shampoo", "Cuidado del Cabello", 5.99, 15, "20/05/2024");
            dataGridView1.Rows.Add("004", "Crema hidratante", "Cuidado de la Piel", 8.99, 8, "30/06/2024");
            dataGridView1.Rows.Add("005", "Desodorante", "Aseo Personal", 4.49, 12, "12/09/2024");

            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.ReadOnly = true; // No editable 
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el evento ocurrió en una fila (y no en los encabezados o en una celda vacía)
            if (e.RowIndex >= 0)
            {
                // Obtén los datos de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCodigoP.Text = row.Cells["Código"].Value.ToString();
                txtNombreP.Text = row.Cells["Column1"].Value.ToString();
                txtDesP.Text = row.Cells["Column3"].Value.ToString();
                txtPrecioP.Text = row.Cells["Column2"].Value.ToString();
                txtCantidadP.Text = row.Cells["Cantidad"].Value.ToString();
                txtFechaCad.Text = row.Cells["Feccad"].Value.ToString();
            }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}