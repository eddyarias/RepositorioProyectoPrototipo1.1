using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._0
{
    public partial class Form_Compras : Form
    {
        public Form_Compras()
        {
            InitializeComponent();
        }

        private void Form_Compras_Load(object sender, EventArgs e)
        {
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2 - 400,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;
        }

        private int indicePestanaActual = 0;
        private void AvanzarPestana()
        {
            // Deshabilitar la pestaña actual
            //TCProveedores.TabPages[indicePestanaActual].Enabled = false;

            // Incrementar el índice de la pestaña actual
            indicePestanaActual++;

            // Habilitar la siguiente pestaña
            if (indicePestanaActual < TCCompras.TabCount)
            {
                TCCompras.TabPages[indicePestanaActual].Enabled = true;
                TCCompras.SelectedIndex = indicePestanaActual;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AvanzarPestana();
        }
    }
}
