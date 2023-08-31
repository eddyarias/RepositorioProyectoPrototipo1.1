using ProyectoPrototipo_1._0;
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

namespace ProyectoPrototipo_1._1.FORMS
{
    public partial class Form_AgregarCliente : Form
    {
        public Connect connect;
        public string CedulaClienteRegistrada { get; private set; }


        string con = "Server=DESKTOP-OUHSBBV;Database=db_farmacia;Integrated Security=True;";

        //public string con = "Server=DESKTOP-0BLRF7R\\MSSQLSERVER01;Database=db_farmacia;Integrated Security=True;";
        public Form_AgregarCliente(Connect connect)
        {
            InitializeComponent();
            this.connect = connect;
            // Configurar el DateTimePicker para mostrar solo el año
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaNacimiento.CustomFormat = "yyyy";
        }

        private void Form_AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cedula = txtBCedula.Text;
            string tipo = comboBoxTipoPersona.Text;
            string nombres = txtBNombres.Text;
            string apellidos = txtBApellidos.Text;
            string direccion = txtBDireccion.Text;
            string correo = txtBEmail.Text;
            string celular = txtBCelular.Text;
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

            GuardarCliente(cedula, tipo, nombres, apellidos, direccion, correo, celular, fechaNacimiento);
        }

        private void GuardarCliente(string cedula, string tipo, string nombres, string apellidos, string direccion, string correo, string celular, DateTime fechaNacimiento)
        {


            try
            {
                // Verifica que todos los campos requeridos estén completos antes de guardar
                if (!string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(nombres) && !string.IsNullOrEmpty(apellidos))
                {

                    // Define la consulta SQL para insertar un nuevo cliente
                    string insertQuery = "INSERT INTO Cliente (cedula, tipo_persona, nombres_c, apellidos_c, direccion_c, email_c, telefono_c, fecha_nac) " +
                        "VALUES (@Cedula, @Tipo, @Nombres, @Apellidos, @Direccion, @Correo, @Celular, @FechaNacimiento)";

                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            // Asigna los valores de los parámetros a las variables en la consulta SQL
                            cmd.Parameters.AddWithValue("@Cedula", cedula);
                            cmd.Parameters.AddWithValue("@Tipo", tipo);
                            cmd.Parameters.AddWithValue("@Nombres", nombres);
                            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                            cmd.Parameters.AddWithValue("@Direccion", direccion);
                            cmd.Parameters.AddWithValue("@Correo", correo);
                            cmd.Parameters.AddWithValue("@Celular", celular);
                            cmd.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                            // Ejecuta la consulta para insertar el nuevo cliente
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente guardado correctamente. Continuar con la venta.");

                                this.CedulaClienteRegistrada = cedula;


                                // Cierra el formulario actual (Form_AgregarCliente)
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el cliente.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }


        private Form_Ventas formVentas;

        public Form_AgregarCliente(Connect connect, Form_Ventas formVentas)
        {
            InitializeComponent();
            this.connect = connect;
            this.formVentas = formVentas; // Asigna la referencia de Form_Ventas al campo privado formVentas
        }


    }


}
