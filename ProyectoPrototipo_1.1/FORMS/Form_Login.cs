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
using ProyectoPrototipo_1._1.CLASES;

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
            string usuario = TBUsername.Text;
            string pass = TBPassword.Text;
            string tipoUsuario = CBTipoUsuario.SelectedItem?.ToString();

            Connect conexion = new Connect();
            SqlConnection connection = conexion.RealizarConexion();

            if (connection != null)
            {
                //Form_Menu form_menu = new Form_Menu(conexion);
                //form_menu.Show();
                //this.Hide();
                try
                {

                    SHA512 hasher = new SHA512();
                    string hashPass = hasher.HashPassword(pass);

                    // La conexión fue exitosa, ahora verifica las credenciales
                    string query = "SELECT COUNT(*) FROM Usuario WHERE username = @usuario AND pass = @pass AND tipo_usuario = @tipo_usuario";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@pass", hashPass);
                        cmd.Parameters.AddWithValue("@tipo_usuario", tipoUsuario);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            // Las credenciales son válidas, permite el acceso
                            Form_Menu form_menu = new Form_Menu(conexion);
                            form_menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Las credenciales no son válidas, muestra un mensaje de error
                            MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                // La conexión falló, muestra un mensaje de error
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void PBVerPassword_Click(object sender, EventArgs e)
        {
            if (TBPassword.PasswordChar == '*')
            {
                TBPassword.PasswordChar = '\0'; // Mostrar contraseña
                PBVerPassword.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoAbierto.jpg");
            }
            else
            {
                TBPassword.PasswordChar = '*'; // Ocultar contraseña
                PBVerPassword.Image = Image.FromFile("RECURSOS/REC_FORM_LOGIN/candadoCerrado.jpg");
            }
        }
    }
}
