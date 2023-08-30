using ProyectoPrototipo_1._1.FORMS;
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
        private Form_Inventario form_Inventario;
        private Form_Ventas form_Ventas;
        private Form_Compras form_Compras;
        private Form_Proveedores form_Proveedores;
        private Form_Clientes form_Clientes;
        private Form_AdministracionDelSistema form_AdminSistema;
        private Form_Login form_Login;
        public Form_Menu()
        {
            InitializeComponent();
            // Instanciar todos los formularios
            form_Inventario = new Form_Inventario();
            form_Ventas = new Form_Ventas();
            form_Compras = new Form_Compras();
            form_Proveedores = new Form_Proveedores();
            form_Clientes = new Form_Clientes();
            form_AdminSistema = new Form_AdministracionDelSistema();
            form_Login=new Form_Login();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cambiar el estado del formulario a maximizado
            this.WindowState = FormWindowState.Maximized;
            form_Login.MdiParent = this;
            form_Login.Show();
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
            HideAllForms();
            form_Inventario.MdiParent = this;
            form_Inventario.Show();
        }



        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_Ventas.MdiParent = this;
            form_Ventas.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_Compras.MdiParent = this;
            form_Compras.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_Proveedores.MdiParent = this;
            form_Proveedores.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_Clientes.MdiParent = this;
            form_Clientes.Show();
        }
        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_AdminSistema.MdiParent = this;
            form_AdminSistema.Show();
        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllForms();
            form_Login.MdiParent = this;
            form_Login.Show();
        }

        private void HideAllForms()
        {
            form_Inventario.Hide();
            form_Ventas.Hide();
            form_Compras.Hide();
            form_Proveedores.Hide();
            form_Clientes.Hide();
            form_AdminSistema.Hide();
            form_Login.Hide();
        }
    }
}
