using Microsoft.EntityFrameworkCore;
using ProyectoPrototipo_1._0.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrototipo_1._1.FORMS
{
    public partial class Form_AdministracionDeUsuarios : Form
    {
        public Form_AdministracionDeUsuarios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Administracion_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
            // Cambiar el estado del formulario a maximizado
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
