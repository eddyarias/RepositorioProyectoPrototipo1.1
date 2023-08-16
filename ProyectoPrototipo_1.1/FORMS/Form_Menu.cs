using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ajustar el tamaño del formulario
            this.Width = 1600; // Ancho del formulario
            this.Height = 1000; // Altura del formulario

            // Centrar el formulario en la pantalla un poco hacia arriba
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2 - 40); ;

        }



        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void moduloProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Proveedores form_Proveedores = new Form_Proveedores();
            form_Proveedores.MdiParent = this;
            form_Proveedores.Show();
        }



        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas form_Ventas = new Form_Ventas();
            form_Ventas.MdiParent = this;
            form_Ventas.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Compras form_Compras = new Form_Compras();
            form_Compras.MdiParent = this;
            form_Compras.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Inventario form_Inventario = new Form_Inventario();
            form_Inventario.MdiParent = this;
            form_Inventario.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Clientes form_Clientes = new Form_Clientes();
            form_Clientes.MdiParent = this;
            form_Clientes.Show();
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
