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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            //Para iniciar sin autenticaciòn
            this.Hide();
            Form_Menu form_Menu = new Form_Menu();
            form_Menu.ShowDialog();


            //SI YA ESTA LISTO EL SQL SERVER, DESCOMENTEN ESTO Y MODIFIQUEN LA CLASE CONNECT:

           /* string usuario = TBUsername.Text;
            string pass = TBPassword.Text;

            Connect conexion = new Connect(usuario, pass);
            SqlConnection connection = conexion.RealizarConexion();

            if (connection != null)
            {
                // La conexión fue exitosa
                MessageBox.Show("Conexión exitosa.");
                this.Hide();
                Form_Menu form_Menu = new Form_Menu();
                form_Menu.ShowDialog();
            }
            else
            {
                // La conexión falló, muestra un mensaje de error
                MessageBox.Show("Error al conectar a la base de datos.");
            }*/
        }
    }
}
